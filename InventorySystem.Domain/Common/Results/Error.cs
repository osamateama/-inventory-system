namespace InventorySystem.Domain.Common.Results;

public readonly record struct Error
{
    private Error(string code,string description, ErrorKind kind)
    {
        Code = code;
        Description = description;
        Kind = kind;
    }
    public  string Code { get; }
    public string Description { get; }
    public ErrorKind Kind { get; }
    
    // Factory methods 
    public static Error Failure(string code = nameof(Failure), string description = "General Failure.")
        => new(code, description, ErrorKind.Failure);

    public static Error Unexpected(string code = nameof(Unexpected), string description = "Unexpected Error Occurred.")
        => new(code, description, ErrorKind.Unexpected);

    public static Error Validation(string code, string description)
        => new(code, description, ErrorKind.Validation);

    public static Error Conflict(string code, string description)
        => new(code, description, ErrorKind.Conflict);

    public static Error NotFound(string code, string description)
        => new(code, description, ErrorKind.NotFound);

    public static Error Unauthorized(string code = nameof(Unauthorized), string description = "Unauthorized Access.")
        => new(code, description, ErrorKind.Unauthorized);

    public static Error Forbidden(string code = nameof(Forbidden), string description = "Forbidden Access.")
        => new(code, description, ErrorKind.Forbidden);

}