using System.Runtime.InteropServices;

namespace StreamCasa.Abstractions.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
