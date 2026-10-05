using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A0 RID: 13728
	[Token(Token = "0x20035A0")]
	public struct DefaultCharBuildFactory<TChar> : ICharCardBuildFactory<TChar>, IHotfixable where TChar : class, ICharacterCardViewModel, new()
	{
		// Token: 0x06015D52 RID: 89426 RVA: 0x0008E260 File Offset: 0x0008C460
		[Token(Token = "0x6015D52")]
		public static DefaultCharBuildFactory<TChar> FromPlayerChar(PlayerCharacter playerChar, bool instAble, [Optional] string skillId, [Optional] string equipId)
		{
			return default(DefaultCharBuildFactory<TChar>);
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x06015D53 RID: 89427 RVA: 0x0008E278 File Offset: 0x0008C478
		[Token(Token = "0x1700342C")]
		public bool isEmpty
		{
			[Token(Token = "0x6015D53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015D54 RID: 89428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D54")]
		public void BuildTo(TChar targetChar)
		{
		}

		// Token: 0x06015D55 RID: 89429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015D55")]
		public TChar BuildNew()
		{
			return null;
		}

		// Token: 0x0401A434 RID: 107572
		[Token(Token = "0x401A434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public PlayerCharacter playerChar;

		// Token: 0x0401A435 RID: 107573
		[Token(Token = "0x401A435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool instAble;

		// Token: 0x0401A436 RID: 107574
		[Token(Token = "0x401A436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string skillId;

		// Token: 0x0401A437 RID: 107575
		[Token(Token = "0x401A437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string equipId;

		// Token: 0x0401A438 RID: 107576
		[Token(Token = "0x401A438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FromPlayerChar;

		// Token: 0x0401A439 RID: 107577
		[Token(Token = "0x401A439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0401A43A RID: 107578
		[Token(Token = "0x401A43A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BuildTo;

		// Token: 0x0401A43B RID: 107579
		[Token(Token = "0x401A43B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BuildNew;
	}
}
