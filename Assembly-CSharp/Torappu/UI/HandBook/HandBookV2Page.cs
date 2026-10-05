using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E8 RID: 26344
	[Token(Token = "0x20066E8")]
	public class HandBookV2Page : StateEnginePage
	{
		// Token: 0x17005994 RID: 22932
		// (get) Token: 0x06025CE5 RID: 154853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025CE6 RID: 154854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005994")]
		public HandBookJumpParam jumpParam
		{
			[Token(Token = "0x6025CE5")]
			[Address(RVA = "0x20C87F0", Offset = "0x20C73F0", VA = "0x1820C87F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025CE6")]
			[Address(RVA = "0x20C8850", Offset = "0x20C7450", VA = "0x1820C8850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025CE7 RID: 154855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CE7")]
		[Address(RVA = "0x20C8220", Offset = "0x20C6E20", VA = "0x1820C8220")]
		public HandBookV2MapPosData GetData()
		{
			return null;
		}

		// Token: 0x06025CE8 RID: 154856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CE8")]
		[Address(RVA = "0x20C82A0", Offset = "0x20C6EA0", VA = "0x1820C82A0")]
		public HandBookV2ForceMapData GetForceMapData()
		{
			return null;
		}

		// Token: 0x06025CE9 RID: 154857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CE9")]
		[Address(RVA = "0x20C86D0", Offset = "0x20C72D0", VA = "0x1820C86D0")]
		private void _ReturnPage()
		{
		}

		// Token: 0x06025CEA RID: 154858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CEA")]
		[Address(RVA = "0x20C8320", Offset = "0x20C6F20", VA = "0x1820C8320", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06025CEB RID: 154859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CEB")]
		[Address(RVA = "0x20C8580", Offset = "0x20C7180", VA = "0x1820C8580")]
		public void SetTopMenuActive(bool activeFlag)
		{
		}

		// Token: 0x06025CEC RID: 154860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CEC")]
		[Address(RVA = "0x20C83D0", Offset = "0x20C6FD0", VA = "0x1820C83D0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06025CED RID: 154861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CED")]
		[Address(RVA = "0x20C8790", Offset = "0x20C7390", VA = "0x1820C8790")]
		public HandBookV2Page()
		{
		}

		// Token: 0x06025CF1 RID: 154865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CF1")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06025CF2 RID: 154866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CF2")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04035267 RID: 217703
		[Token(Token = "0x4035267")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04035268 RID: 217704
		[Token(Token = "0x4035268")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private HandBookV2MapPosDB _handbookPosDBComponent;

		// Token: 0x04035269 RID: 217705
		[Token(Token = "0x4035269")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private HandBookV2ForceMapDB _handbookForceMapDBComponent;

		// Token: 0x0403526B RID: 217707
		[Token(Token = "0x403526B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpParam;

		// Token: 0x0403526C RID: 217708
		[Token(Token = "0x403526C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_jumpParam;

		// Token: 0x0403526D RID: 217709
		[Token(Token = "0x403526D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0403526E RID: 217710
		[Token(Token = "0x403526E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetForceMapData;

		// Token: 0x0403526F RID: 217711
		[Token(Token = "0x403526F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x04035270 RID: 217712
		[Token(Token = "0x4035270")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04035271 RID: 217713
		[Token(Token = "0x4035271")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetTopMenuActive;

		// Token: 0x04035272 RID: 217714
		[Token(Token = "0x4035272")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04035273 RID: 217715
		[Token(Token = "0x4035273")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
