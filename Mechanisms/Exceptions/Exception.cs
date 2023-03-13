using System;

namespace PlainFieldSimulator.Exceptions
{
    public class EquipmentNotAvailable : Exception
    {
        public EquipmentNotAvailable()
        {
        }

        public EquipmentNotAvailable(string message)
            : base(message)
        {
        }

        public EquipmentNotAvailable(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class OccupationNotAvailable : Exception
    {
        public OccupationNotAvailable()
        {
        }

        public OccupationNotAvailable(string message)
            : base(message)
        {
        }

        public OccupationNotAvailable(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class AbilityDuplicated : Exception
    {
        public AbilityDuplicated()
        {
        }

        public AbilityDuplicated(string message)
            : base(message)
        {
        }

        public AbilityDuplicated(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class NoWeaponFound : Exception
    {
        public NoWeaponFound()
        {
        }

        public NoWeaponFound(string message)
            : base(message)
        {
        }

        public NoWeaponFound(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class WeaponDuplicated : Exception
    {
        public WeaponDuplicated()
        {
        }

        public WeaponDuplicated(string message)
            : base(message)
        {
        }

        public WeaponDuplicated(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class WeaponListFull : Exception
    {
        public WeaponListFull()
        {
        }

        public WeaponListFull(string message)
            : base(message)
        {
        }

        public WeaponListFull(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class MaximumLevelApproached : Exception
    {
        public MaximumLevelApproached()
        {
        }

        public MaximumLevelApproached(string message)
            : base(message)
        {
        }

        public MaximumLevelApproached(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class DifficultyCannotRecognize : Exception
    {
        public DifficultyCannotRecognize()
        {
        }

        public DifficultyCannotRecognize(string message)
            : base(message)
        {
        }

        public DifficultyCannotRecognize(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class InvalidPosition : Exception
    {
        public InvalidPosition()
        {
        }

        public InvalidPosition(string message)
            : base(message)
        {
        }

        public InvalidPosition(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class UnitNotFound : Exception
    {
        public UnitNotFound()
        {
        }

        public UnitNotFound(string message)
            : base(message)
        {
        }

        public UnitNotFound(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class OutOfMovementRange : Exception
    {
        public OutOfMovementRange()
        {
        }

        public OutOfMovementRange(string message)
            : base(message)
        {
        }

        public OutOfMovementRange(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
