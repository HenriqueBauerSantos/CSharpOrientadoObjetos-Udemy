namespace ExercAula220.Entitie
{
    class LogRegister
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public LogRegister(string name, DateTime instant) {
            Name = name;
            Instant = instant;
        }

        public override int GetHashCode() {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is LogRegister))
            {
                return false;
            }
            LogRegister other = obj as LogRegister;
            return Name.Equals(other.Name);
        }

    }
}
