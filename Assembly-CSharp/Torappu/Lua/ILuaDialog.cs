using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001610 RID: 5648
	[Token(Token = "0x2001610")]
	[CSharpCallLua]
	public interface ILuaDialog : ILuaCallCSharp
	{
		// Token: 0x06008037 RID: 32823
		[Token(Token = "0x6008037")]
		void ClosedByParent();

		// Token: 0x06008038 RID: 32824
		[Token(Token = "0x6008038")]
		Transform GetHookRoot();

		// Token: 0x06008039 RID: 32825
		[Token(Token = "0x6008039")]
		string GetData(string key);

		// Token: 0x0600803A RID: 32826
		[Token(Token = "0x600803A")]
		void RequestClose(ILuaDialog child);

		// Token: 0x0600803B RID: 32827
		[Token(Token = "0x600803B")]
		Sprite LoadSprite(string path);

		// Token: 0x0600803C RID: 32828
		[Token(Token = "0x600803C")]
		GameObject LoadPrefab(string path);

		// Token: 0x0600803D RID: 32829
		[Token(Token = "0x600803D")]
		LuaLayout LoadLayout(string path);

		// Token: 0x0600803E RID: 32830
		[Token(Token = "0x600803E")]
		ScriptableObject LoadScriptableObject(string path);

		// Token: 0x0600803F RID: 32831
		[Token(Token = "0x600803F")]
		LuaLayout GetLuaLayout();

		// Token: 0x06008040 RID: 32832
		[Token(Token = "0x6008040")]
		void ShowEnterEffect();

		// Token: 0x06008041 RID: 32833
		[Token(Token = "0x6008041")]
		bool IsEnterEffectEnd();

		// Token: 0x06008042 RID: 32834
		[Token(Token = "0x6008042")]
		UnityEngine.Object UICompDialogHost();
	}
}
