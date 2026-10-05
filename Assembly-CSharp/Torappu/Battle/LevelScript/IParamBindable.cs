using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200287A RID: 10362
	[Token(Token = "0x200287A")]
	public interface IParamBindable
	{
		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06011406 RID: 70662
		// (set) Token: 0x06011407 RID: 70663
		[Token(Token = "0x17002611")]
		[JsonIgnore]
		ActionContext context { [Token(Token = "0x6011406")] get; [Token(Token = "0x6011407")] set; }

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06011408 RID: 70664
		[Token(Token = "0x17002612")]
		Type paramType { [Token(Token = "0x6011408")] get; }

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06011409 RID: 70665
		[Token(Token = "0x17002613")]
		string bindingPath { [Token(Token = "0x6011409")] get; }

		// Token: 0x0601140A RID: 70666
		[Token(Token = "0x601140A")]
		void ClearBind();

		// Token: 0x0601140B RID: 70667
		[Token(Token = "0x601140B")]
		bool Bind(ParamVariable variable);
	}
}
