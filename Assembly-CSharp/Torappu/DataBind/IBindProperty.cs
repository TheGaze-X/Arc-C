using System;
using Il2CppDummyDll;

namespace Torappu.DataBind
{
	// Token: 0x0200148B RID: 5259
	[Token(Token = "0x200148B")]
	public interface IBindProperty
	{
		// Token: 0x06007999 RID: 31129
		[Token(Token = "0x6007999")]
		void Update(DataBindSystem system);

		// Token: 0x0600799A RID: 31130
		[Token(Token = "0x600799A")]
		object GetUntypedValue();

		// Token: 0x0600799B RID: 31131
		[Token(Token = "0x600799B")]
		void LuaDataBinder_AddOrRemove(LuaDataBinder binder, bool add);
	}
}
