namespace PrimaryCtorAndRecordTypes.Sample;

public record MyTestRecord(int Johnson, int? Peter)
{
    public MyTestRecord(int Johnson) : this(Johnson: Johnson, Peter: null) {}

    public int Johnson { get; init; } = Johnson;
}

public class MyTestClass
{
    public MyTestClass(int Johnson) {}
}

public static class TesterRecord
{
    public static void test()
    {
        var usingPctor = new MyTestRecord(1, Peter: 2);

        var usingSec = new MyTestRecord(12);

        usingSec = usingSec with { Peter = 12 };

        var myTestClass = new MyTestClass(12);
    }
}