using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063CA RID: 25546
	[Token(Token = "0x20063CA")]
	public class AutoChessCharSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x06024D5B RID: 150875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056FA")]
		public TemplateCharSelectMainProperty property
		{
			[Token(Token = "0x6024D5B")]
			[Address(RVA = "0x1FBCA80", Offset = "0x1FBB680", VA = "0x181FBCA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024D5C RID: 150876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D5C")]
		[Address(RVA = "0x1FBC220", Offset = "0x1FBAE20", VA = "0x181FBC220")]
		public void SetInputData(TemplateCharSelectController.InputParam inputParam)
		{
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x06024D5D RID: 150877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056FB")]
		public TemplateCharSelectController.InputParam inputParam
		{
			[Token(Token = "0x6024D5D")]
			[Address(RVA = "0x1FBCA20", Offset = "0x1FBB620", VA = "0x181FBCA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024D5E RID: 150878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D5E")]
		[Address(RVA = "0x1FBBDA0", Offset = "0x1FBA9A0", VA = "0x181FBBDA0")]
		public TemplateCharSelectCardViewModel CreateCardViewModel(int instId, TemplateCharSelectCharInputData inputNullable, [Optional] PlayerCharacter playerData)
		{
			return null;
		}

		// Token: 0x06024D5F RID: 150879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D5F")]
		[Address(RVA = "0x1FBC380", Offset = "0x1FBAF80", VA = "0x181FBC380")]
		private AutoChessCharSelectStateBean.DIYInfo _CheckInChess(PlayerCharacter playerData, string actId, ActAutoChessData actData)
		{
			return null;
		}

		// Token: 0x06024D60 RID: 150880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D60")]
		[Address(RVA = "0x1FBC840", Offset = "0x1FBB440", VA = "0x181FBC840")]
		private static string _GetDefaultEquip(CharQuery charQuery)
		{
			return null;
		}

		// Token: 0x06024D61 RID: 150881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D61")]
		[Address(RVA = "0x1FBC980", Offset = "0x1FBB580", VA = "0x181FBC980")]
		public AutoChessCharSelectStateBean()
		{
		}

		// Token: 0x040337F8 RID: 210936
		[Token(Token = "0x40337F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TemplateCharSelectController.InputParam m_param;

		// Token: 0x040337F9 RID: 210937
		[Token(Token = "0x40337F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TemplateCharSelectMainProperty m_property;

		// Token: 0x040337FA RID: 210938
		[Token(Token = "0x40337FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ActAutoChessData.ActAutoChessCharShopChessData m_forChess;

		// Token: 0x040337FB RID: 210939
		[Token(Token = "0x40337FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, AutoChessCharSelectStateBean.DIYInfo> m_diyChess;

		// Token: 0x040337FC RID: 210940
		[Token(Token = "0x40337FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x040337FD RID: 210941
		[Token(Token = "0x40337FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetInputData;

		// Token: 0x040337FE RID: 210942
		[Token(Token = "0x40337FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_inputParam;

		// Token: 0x040337FF RID: 210943
		[Token(Token = "0x40337FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateCardViewModel;

		// Token: 0x04033800 RID: 210944
		[Token(Token = "0x4033800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckInChess;

		// Token: 0x04033801 RID: 210945
		[Token(Token = "0x4033801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetDefaultEquip;

		// Token: 0x04033802 RID: 210946
		[Token(Token = "0x4033802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020063CB RID: 25547
		[Token(Token = "0x20063CB")]
		private class DIYInfo
		{
			// Token: 0x06024D62 RID: 150882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024D62")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DIYInfo()
			{
			}

			// Token: 0x04033803 RID: 210947
			[Token(Token = "0x4033803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04033804 RID: 210948
			[Token(Token = "0x4033804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ActAutoChessData.ActAutoChessCharShopChessData chessData;

			// Token: 0x04033805 RID: 210949
			[Token(Token = "0x4033805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int skillIndex;

			// Token: 0x04033806 RID: 210950
			[Token(Token = "0x4033806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string currentEquip;

			// Token: 0x04033807 RID: 210951
			[Token(Token = "0x4033807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string skin;
		}
	}
}
