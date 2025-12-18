using Microsoft.AspNetCore.Identity;

namespace JSDeposito.Infrastructure.Identity;

public class Usuario : IdentityUser<Guid>
{
    public string Nome { get; set; }
}
