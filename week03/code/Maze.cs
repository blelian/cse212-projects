/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers representing locations in the maze.
/// 'left', 'right', 'up', and 'down' are booleans representing valid directions.
///
/// If a direction is false, then there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, an InvalidOperationException with the message
/// "Can't go that way!" will be thrown. Otherwise, the 'currX' and 'currY'
/// values will be updated accordingly.
/// </summary>
public class Maze
{
    // Dictionary storing the maze layout; keys are coordinates (x,y), values are boolean arrays for directions
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;

    // Current position in the maze; starting point is (1,1)
    private int _currX = 1;
    private int _currY = 1;

    // Constructor to initialize the maze map
    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Attempt to move left from the current position.
    /// If movement is blocked (wall or invalid coordinate), throw an exception.
    /// Otherwise, decrement the X coordinate.
    /// </summary>
    public void MoveLeft()
    {
        var pos = (_currX, _currY);

        // Check if the current position exists and left movement is allowed
        if (!_mazeMap.ContainsKey(pos) || !_mazeMap[pos][0])
            throw new InvalidOperationException("Can't go that way!"); // Wall encountered

        _currX--; // Move left
    }

    /// <summary>
    /// Attempt to move right from the current position.
    /// If movement is blocked (wall or invalid coordinate), throw an exception.
    /// Otherwise, increment the X coordinate.
    /// </summary>
    public void MoveRight()
    {
        var pos = (_currX, _currY);

        // Check if the current position exists and right movement is allowed
        if (!_mazeMap.ContainsKey(pos) || !_mazeMap[pos][1])
            throw new InvalidOperationException("Can't go that way!"); // Wall encountered

        _currX++; // Move right
    }

    /// <summary>
    /// Attempt to move up from the current position.
    /// If movement is blocked (wall or invalid coordinate), throw an exception.
    /// Otherwise, decrement the Y coordinate.
    /// </summary>
    public void MoveUp()
    {
        var pos = (_currX, _currY);

        // Check if the current position exists and up movement is allowed
        if (!_mazeMap.ContainsKey(pos) || !_mazeMap[pos][2])
            throw new InvalidOperationException("Can't go that way!"); // Wall encountered

        _currY--; // Move up
    }

    /// <summary>
    /// Attempt to move down from the current position.
    /// If movement is blocked (wall or invalid coordinate), throw an exception.
    /// Otherwise, increment the Y coordinate.
    /// </summary>
    public void MoveDown()
    {
        var pos = (_currX, _currY);

        // Check if the current position exists and down movement is allowed
        if (!_mazeMap.ContainsKey(pos) || !_mazeMap[pos][3])
            throw new InvalidOperationException("Can't go that way!"); // Wall encountered

        _currY++; // Move down
    }

    /// <summary>
    /// Returns a string representing the current location of the player in the maze.
    /// </summary>
    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}
