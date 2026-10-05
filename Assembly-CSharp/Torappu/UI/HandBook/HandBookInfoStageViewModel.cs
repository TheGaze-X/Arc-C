using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200667F RID: 26239
	[Token(Token = "0x200667F")]
	public class HandBookInfoStageViewModel : IHotfixable
	{
		// Token: 0x06025ABD RID: 154301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABD")]
		[Address(RVA = "0x2094CC0", Offset = "0x20938C0", VA = "0x182094CC0")]
		public void LoadData(HandBookInfoStagePage.Params param)
		{
		}

		// Token: 0x06025ABE RID: 154302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABE")]
		[Address(RVA = "0x2094A60", Offset = "0x2093660", VA = "0x182094A60")]
		public void LoadDataByJumpParam(HandBookJumpParam jumpParam)
		{
		}

		// Token: 0x06025ABF RID: 154303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025ABF")]
		[Address(RVA = "0x2094D90", Offset = "0x2093990", VA = "0x182094D90")]
		private void _LoadCharData(string charId)
		{
		}

		// Token: 0x06025AC0 RID: 154304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025AC0")]
		[Address(RVA = "0x2094EF0", Offset = "0x2093AF0", VA = "0x182094EF0")]
		public HandBookInfoStageViewModel()
		{
		}

		// Token: 0x04034ED9 RID: 216793
		[Token(Token = "0x4034ED9")]
		[FieldOffset(Offset = "0x10")]
		public HandBookStageViewModel handbookViewModel;

		// Token: 0x04034EDA RID: 216794
		[Token(Token = "0x4034EDA")]
		[FieldOffset(Offset = "0x18")]
		public SkillGroupViewModel skillGroupModel;

		// Token: 0x04034EDB RID: 216795
		[Token(Token = "0x4034EDB")]
		[FieldOffset(Offset = "0x20")]
		public List<int> charList;

		// Token: 0x04034EDC RID: 216796
		[Token(Token = "0x4034EDC")]
		[FieldOffset(Offset = "0x28")]
		public int selectIdx;

		// Token: 0x04034EDD RID: 216797
		[Token(Token = "0x4034EDD")]
		[FieldOffset(Offset = "0x30")]
		public Sprite logoSprite;

		// Token: 0x04034EDE RID: 216798
		[Token(Token = "0x4034EDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034EDF RID: 216799
		[Token(Token = "0x4034EDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataByJumpParam;

		// Token: 0x04034EE0 RID: 216800
		[Token(Token = "0x4034EE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCharData;

		// Token: 0x04034EE1 RID: 216801
		[Token(Token = "0x4034EE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
