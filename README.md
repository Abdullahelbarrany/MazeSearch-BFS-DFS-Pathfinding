
# MazeSearch - BFS & DFS Pathfinding

## Description 


MazeSearch is a C# application that implements Breadth-First Search (BFS) and Depth-First Search (DFS) to navigate a maze-like grid represented in an Excel-style DataGridView. Users can interact with the grid by selecting the hero's start location, goal location, and obstacles. The program then searches for a path using the selected algorithm and visually represents the traversal.

## Features

**-Interactive Grid:** Users can click on cells to set the start point (hero), goal, and obstacles.

**-Pathfinding Algorithms:** Supports both BFS (shortest path) and DFS (deep search).

**-Excel Integration:** Uses Excel-like DataGridView where writing is disabled.

**-Visual Representation:**
    
    Blue: Hero's start position.
    Green: Goal location.
    Black: Obstacles.
    Cyan: Visited nodes during the search.
    Gold: Final path to the goal (BFS only).

**-Real-Time Processing:** Users can dynamically place obstacles and watch the algorithm adjust.


## Code Overview

**DFS & BFS Algorithms:**

**-BFS (Breadth-First Search)** uses a list to explore nodes level by level, ensuring the shortest path.

**-DFS (Depth-First Search)** uses a stack to prioritize deeper paths before backtracking.

-A **visited list** ensures no node is revisited.

**Cell Interaction:**

     -The **board_CellClick** method assigns colors based on user input.

     -The **explorenodes** method finds valid neighboring nodes for search.

**Grid Initialization:**

    -The Maze_Load method sets up a **21x21 grid** with a white background.

    -Column widths are adjusted dynamically.
## Getting Started 

## Step 1: Set Up Your Maze

-Click on a grid cell to place the Hero's Start Position (Blue).
<img src="https://github.com/Abdullahelbarrany/MazeSearch-BFS-DFS-Pathfinding/blob/main/Maze%20screenshots/Screenshot%202025-01-28%20231304.png?raw=true"  align="center" width="600" height="600">


-Click another cell to set the Goal Location (Green).
<img src="https://github.com/Abdullahelbarrany/MazeSearch-BFS-DFS-Pathfinding/blob/main/Maze%20screenshots/Screenshot%202025-01-28%20231328.png?raw=true"  align="center" width="600" height="600">


-Click additional cells to add Obstacles (Black) to block the path.
<img src="https://github.com/Abdullahelbarrany/MazeSearch-BFS-DFS-Pathfinding/blob/main/Maze%20screenshots/Screenshot%202025-01-28%20231346.png?raw=true"  align="center" width="600" height="600">


## Step 2: Choose a Search Algorithm

Breadth-First Search (BFS): Guarantees the shortest path but explores widely.

Depth-First Search (DFS): Dives deep first, may take longer paths.

<img src="https://github.com/Abdullahelbarrany/MazeSearch-BFS-DFS-Pathfinding/blob/main/Maze%20screenshots/Screenshot%20(142).png?raw=true"  align="center" width="600" height="600">

## Step 3: Watch the Pathfinding in Action
The selected algorithm explores nodes, marking them Cyan as visited.

The **shortest path** is highlighted in Gold when the goal is reached.
<img src="https://github.com/Abdullahelbarrany/MazeSearch-BFS-DFS-Pathfinding/blob/main/Maze%20screenshots/Screenshot%202025-01-28%20231448.png?raw=true"  align="center" width="600" height="600">







