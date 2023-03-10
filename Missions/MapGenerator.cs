using System.Collections.Generic;
using PlainFieldSimulator.Algorithms;
using PlainFieldSimulator.BattleField;
using PlainFieldSimulator.Exceptions;
using PlainFieldSimulator.Units;

namespace PlainFieldSimulator.Missions
{
    public abstract class MapGenerator
    {
        // 地图
        private List<List<Cell>> board;

        public MapGenerator()
        {
            board = new List<List<Cell>>();
        }

        public Cell GetCell(Position p)
        {
            return board[p.X][p.Y];
        }

        public List<List<Cell>> Board { get { return board; } set { board = value; } }
    }

    public class Mission1Board : MapGenerator
    {
        public Mission1Board() : base()
        {
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            }); 
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new HighWall(), new HighWall(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new RecoveryPhalanx(), new HighWall(), new HighWall(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new RecoveryPhalanx(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new RecoveryPhalanx(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new HighWall(), new HighWall(), new HighWall(), new RecoveryPhalanx(), new GrassLand(), new GrassLand(), new GrassLand(), new HighWall(), new HighWall(), new HighWall(), new HighWall(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new SandSurface(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
            Board.Add(new List<Cell>()
            {
                new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new DecoratedEdgeWall(), new DecoratedEdgeWall(), new DecoratedEdgeGate(), new DecoratedEdgeGate(), new DecoratedEdgeWall(), new DecoratedEdgeWall(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand(), new Grandstand()
            });
        }
    }
}
