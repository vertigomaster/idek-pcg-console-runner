using IDEK.PCG.StructureGen.Core;
using IDEK.PCG.StructureGen.Core.Enums;

namespace IDEK.PCG.ConsoleRunner;

public class FloorDivisionTestRunner : IPcgRunner
{
    //TODO: Serialize from JSON instead
    public static Room[] BuildTestRooms() => [
        new Room() {
            Name = "Master Suite",
            DesiredFloor = 2,
            EstimatedSize = 350f,
            MinSize = 200f,
            Priority = PlacementPriority.Critical
        },
        new Room() {
            Name = "Kitchen",
            DesiredFloor = 1,
            EstimatedSize = 250f,
            MinSize = 200f,
            Priority = PlacementPriority.Critical
        },
        new Room() {
            Name = "Minor Bed 1",
            DesiredFloor = 2,
            EstimatedSize = 130f,
            MinSize = 80f,
            Priority = PlacementPriority.Need
        },
        new Room() {
            Name = "Minor Bed 2",
            DesiredFloor = 2,
            EstimatedSize = 130f,
            MinSize = 80f,
            Priority = PlacementPriority.Need
        },
        new Room() {
            Name = "Shared Bathroom",
            DesiredFloor = 0,
            EstimatedSize = 30,
            MinSize = 27,
            Priority = PlacementPriority.Need
        },
        new Room() {
            Name = "Living Room",
            DesiredFloor = 1,
            EstimatedSize = 250f,
            MinSize = 200,
            Priority = PlacementPriority.NiceToHave
        },
        new Room() {
            Name = "Dining Room",
            DesiredFloor = 1,
            EstimatedSize = 250f,
            MinSize = 150,
            Priority = PlacementPriority.NiceToHave
        },
        new Room() {
            Name = "Den",
            DesiredFloor = 0,
            EstimatedSize = 200,
            MinSize = 150,
            Priority = PlacementPriority.Luxury,
        },
        new Room() {
            Name = "Mudroom",
            DesiredFloor = 1,
            EstimatedSize = 50,
            MinSize = 36,
            Priority = PlacementPriority.Luxury
        },
        new Room() {
            Name = "Sunroom",
            DesiredFloor = 1,
            EstimatedSize = 200,
            MinSize = 150,
            Priority = PlacementPriority.Luxury
        },
        new Room() {
            Name = "Porch",
            DesiredFloor = 1,
            EstimatedSize = 400,
            MinSize = 100,
            Priority = PlacementPriority.NiceToHave,
            WindowFlags = WindowFlag.NoneAllowed,
            WeightSupportFactor = 0.25f, //it just has some small beams and is mostly external.
            ValidPlacement = PlacementSection.OnGroundFloor
        },
        new Room()
        {
            Name = "Balcony",
            DesiredFloor = 2,
            EstimatedSize = 50,
            MinSize = 25,
            Priority = PlacementPriority.Luxury,
            WindowFlags = WindowFlag.NoneAllowed,
            WeightSupportFactor = 0f, //it's just a balcony
            ValidPlacement = PlacementSection.UpperFloor
        }
    ];

    /// <summary>
    /// Fills out new Lists/data structures ahead of time so that they are cached for the various passes.
    /// </summary>
    protected virtual void PopulateFilteredRoomSubsets()
    {
        
    }
    
    /// <summary>
    /// We first see if we can successfully place any rooms that require specific floors.
    /// </summary>
    protected virtual void RunIdealRoomPass()
    {
            
    }

    protected virtual void RunNonPrefRoomPass()
    {
        
    }

    /// <summary>
    /// If the building proves too large or doesn't fit within the tolerances of the desired floor ratios,
    /// we need to find rooms that we can squish down.
    /// </summary>
    protected virtual void RunSquishPass()
    {
        
    }

    #region Implementation of IPcgRunner

    /// <inheritdoc />
    public int Run()
    {
        return 0;
    }

    #endregion
}