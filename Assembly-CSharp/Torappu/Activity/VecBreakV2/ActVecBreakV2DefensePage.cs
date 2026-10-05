using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E00 RID: 28160
	[Token(Token = "0x2006E00")]
	public class ActVecBreakV2DefensePage : StateEnginePage
	{
		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x06028168 RID: 164200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ED0")]
		public string actId
		{
			[Token(Token = "0x6028168")]
			[Address(RVA = "0x2362490", Offset = "0x2361090", VA = "0x182362490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x06028169 RID: 164201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ED1")]
		public string focusStageId
		{
			[Token(Token = "0x6028169")]
			[Address(RVA = "0x2362560", Offset = "0x2361160", VA = "0x182362560")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x0602816A RID: 164202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ED2")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x602816A")]
			[Address(RVA = "0x2362500", Offset = "0x2361100", VA = "0x182362500")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602816B RID: 164203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602816B")]
		[Address(RVA = "0x2362110", Offset = "0x2360D10", VA = "0x182362110", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602816C RID: 164204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602816C")]
		[Address(RVA = "0x2362350", Offset = "0x2360F50", VA = "0x182362350")]
		private void _PageBack()
		{
		}

		// Token: 0x0602816D RID: 164205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602816D")]
		[Address(RVA = "0x2362430", Offset = "0x2361030", VA = "0x182362430")]
		public ActVecBreakV2DefensePage()
		{
		}

		// Token: 0x0602816F RID: 164207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602816F")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04038E12 RID: 232978
		[Token(Token = "0x4038E12")]
		public const string KEY_PARAM_BUNDLE = "key_vec_break_v2_defense_param";

		// Token: 0x04038E13 RID: 232979
		[Token(Token = "0x4038E13")]
		[FieldOffset(Offset = "0xF0")]
		private ActVecBreakV2DefensePage.InputParams m_cacheParam;

		// Token: 0x04038E14 RID: 232980
		[Token(Token = "0x4038E14")]
		[FieldOffset(Offset = "0xF8")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x04038E15 RID: 232981
		[Token(Token = "0x4038E15")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04038E16 RID: 232982
		[Token(Token = "0x4038E16")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x04038E17 RID: 232983
		[Token(Token = "0x4038E17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04038E18 RID: 232984
		[Token(Token = "0x4038E18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_focusStageId;

		// Token: 0x04038E19 RID: 232985
		[Token(Token = "0x4038E19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x04038E1A RID: 232986
		[Token(Token = "0x4038E1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04038E1B RID: 232987
		[Token(Token = "0x4038E1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PageBack;

		// Token: 0x04038E1C RID: 232988
		[Token(Token = "0x4038E1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E01 RID: 28161
		[Token(Token = "0x2006E01")]
		public class InputParams
		{
			// Token: 0x06028170 RID: 164208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028170")]
			[Address(RVA = "0x2373F20", Offset = "0x2372B20", VA = "0x182373F20")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06028171 RID: 164209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028171")]
			[Address(RVA = "0x2373E00", Offset = "0x2372A00", VA = "0x182373E00")]
			public static ActVecBreakV2DefensePage.InputParams Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06028172 RID: 164210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028172")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InputParams()
			{
			}

			// Token: 0x04038E1D RID: 232989
			[Token(Token = "0x4038E1D")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04038E1E RID: 232990
			[Token(Token = "0x4038E1E")]
			[FieldOffset(Offset = "0x18")]
			public string focusStageId;
		}
	}
}
