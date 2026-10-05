using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HomeIllustrate
{
	// Token: 0x02004AD2 RID: 19154
	[Token(Token = "0x2004AD2")]
	public class HomeIllustrateStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x0601CC2B RID: 117803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CC2C RID: 117804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043DD")]
		public string charId
		{
			[Token(Token = "0x601CC2B")]
			[Address(RVA = "0x1646590", Offset = "0x1645190", VA = "0x181646590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CC2C")]
			[Address(RVA = "0x1646790", Offset = "0x1645390", VA = "0x181646790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x0601CC2D RID: 117805 RVA: 0x000A9710 File Offset: 0x000A7910
		// (set) Token: 0x0601CC2E RID: 117806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043DE")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x601CC2D")]
			[Address(RVA = "0x16465F0", Offset = "0x16451F0", VA = "0x1816465F0")]
			[CompilerGenerated]
			get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x601CC2E")]
			[Address(RVA = "0x1646810", Offset = "0x1645410", VA = "0x181646810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x0601CC2F RID: 117807 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CC30 RID: 117808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043DF")]
		public CharacterData charData
		{
			[Token(Token = "0x601CC2F")]
			[Address(RVA = "0x1646530", Offset = "0x1645130", VA = "0x181646530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CC30")]
			[Address(RVA = "0x1646710", Offset = "0x1645310", VA = "0x181646710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x0601CC31 RID: 117809 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601CC32 RID: 117810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043E0")]
		public PlayerCharacter playerChar
		{
			[Token(Token = "0x601CC31")]
			[Address(RVA = "0x1646650", Offset = "0x1645250", VA = "0x181646650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601CC32")]
			[Address(RVA = "0x1646880", Offset = "0x1645480", VA = "0x181646880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0601CC33 RID: 117811 RVA: 0x000A9728 File Offset: 0x000A7928
		// (set) Token: 0x0601CC34 RID: 117812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170043E1")]
		public int selectedIndex
		{
			[Token(Token = "0x601CC33")]
			[Address(RVA = "0x16466B0", Offset = "0x16452B0", VA = "0x1816466B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601CC34")]
			[Address(RVA = "0x1646900", Offset = "0x1645500", VA = "0x181646900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601CC35 RID: 117813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC35")]
		[Address(RVA = "0x16458B0", Offset = "0x16444B0", VA = "0x1816458B0")]
		public void InitData()
		{
		}

		// Token: 0x0601CC36 RID: 117814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC36")]
		[Address(RVA = "0x16457B0", Offset = "0x16443B0", VA = "0x1816457B0")]
		public string GetSelectedSkinId()
		{
			return null;
		}

		// Token: 0x0601CC37 RID: 117815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC37")]
		[Address(RVA = "0x1645EA0", Offset = "0x1644AA0", VA = "0x181645EA0")]
		private void _LoadIllusts()
		{
		}

		// Token: 0x0601CC38 RID: 117816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC38")]
		[Address(RVA = "0x1646090", Offset = "0x1644C90", VA = "0x181646090")]
		private static void _LoadSelectableUISkins(PlayerCharacter playerChar, ref List<CharUISkinStruct> skins)
		{
		}

		// Token: 0x0601CC39 RID: 117817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC39")]
		[Address(RVA = "0x1646430", Offset = "0x1645030", VA = "0x181646430")]
		public HomeIllustrateStateBean()
		{
		}

		// Token: 0x04025BEC RID: 154604
		[Token(Token = "0x4025BEC")]
		[FieldOffset(Offset = "0x18")]
		public HomeIllustStruct homeIllust;

		// Token: 0x04025BF2 RID: 154610
		[Token(Token = "0x4025BF2")]
		[FieldOffset(Offset = "0x48")]
		private List<CharUISkinStruct> m_skins;

		// Token: 0x04025BF3 RID: 154611
		[Token(Token = "0x4025BF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04025BF4 RID: 154612
		[Token(Token = "0x4025BF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charId;

		// Token: 0x04025BF5 RID: 154613
		[Token(Token = "0x4025BF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x04025BF6 RID: 154614
		[Token(Token = "0x4025BF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x04025BF7 RID: 154615
		[Token(Token = "0x4025BF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_charData;

		// Token: 0x04025BF8 RID: 154616
		[Token(Token = "0x4025BF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_charData;

		// Token: 0x04025BF9 RID: 154617
		[Token(Token = "0x4025BF9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playerChar;

		// Token: 0x04025BFA RID: 154618
		[Token(Token = "0x4025BFA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_playerChar;

		// Token: 0x04025BFB RID: 154619
		[Token(Token = "0x4025BFB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectedIndex;

		// Token: 0x04025BFC RID: 154620
		[Token(Token = "0x4025BFC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_selectedIndex;

		// Token: 0x04025BFD RID: 154621
		[Token(Token = "0x4025BFD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04025BFE RID: 154622
		[Token(Token = "0x4025BFE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSelectedSkinId;

		// Token: 0x04025BFF RID: 154623
		[Token(Token = "0x4025BFF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadIllusts;

		// Token: 0x04025C00 RID: 154624
		[Token(Token = "0x4025C00")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadSelectableUISkins;

		// Token: 0x04025C01 RID: 154625
		[Token(Token = "0x4025C01")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
