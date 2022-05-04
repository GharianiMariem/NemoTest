using Nemo.Market.Kata.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nemo.Market.Kata.Tests
{
    public class Project
    {
        public int Consumption { get { return BuildingList.Sum(x => x.Consumption); }}
        public List<Pipe> PipeList { get; internal set; }
        public List<Building> BuildingList { get; internal set; }
        public List<PowerPlant> PowerPlantList { get; internal set; }
        public Project()
        {
            PipeList = new List<Pipe>();
            BuildingList = new List<Building>();
            PowerPlantList = new List<PowerPlant>();
        }

        public IEnumerable<Pipe> GetPipes()
        {
            return PipeList;
        }


        public void Add(Pipe pipe)
        {
            foreach (Pipe b in PipeList)
            {
                if (pipe.Position == b.Position)
                {
                    throw new ArgumentException();
                }
            }
            this.PipeList.Add(pipe);

        }
        public void Add(Building building)
        {

            foreach(Building b in BuildingList)
            {
                if(building.Position == b.Position)
                {
                    throw new ArgumentException();
                }
            }
            this.BuildingList.Add(building);

        }
        public void Add(PowerPlant plant)
        {

            foreach (PowerPlant b in PowerPlantList)
            {
                if (plant.Position == b.Position)
                {
                    throw new ArgumentException();
                }
            }
            this.PowerPlantList.Add(plant);

        }
        

        public IEnumerable<Building> GetBuildings()
        {
            return BuildingList;
        }

        internal IEnumerable<PowerPlant> GetPlants()
        {
            return PowerPlantList;
        }
    }
}