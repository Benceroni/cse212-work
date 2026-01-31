public class FeatureCollection
{
    public Feature[] Features { get; set; }
}

public class Feature
    {
        public Geography Properties { get; set; }
    }

public class Geography
    {
        public float Mag { get; set; }
        public string Place { get; set; }
    }