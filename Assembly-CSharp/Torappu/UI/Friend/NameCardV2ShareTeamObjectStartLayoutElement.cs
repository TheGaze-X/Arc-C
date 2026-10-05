using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DE4 RID: 19940
	[Token(Token = "0x2004DE4")]
	public class NameCardV2ShareTeamObjectStartLayoutElement : CrossAppShareStartBaseLayoutElement
	{
		// Token: 0x0601DCF6 RID: 122102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DCF6")]
		[Address(RVA = "0x1767C40", Offset = "0x1766840", VA = "0x181767C40", Slot = "4")]
		public override CrossAppShareElementModelCollector GetElementModelCollector()
		{
			return null;
		}

		// Token: 0x0601DCF7 RID: 122103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCF7")]
		[Address(RVA = "0x1767D90", Offset = "0x1766990", VA = "0x181767D90")]
		public NameCardV2ShareTeamObjectStartLayoutElement()
		{
		}

		// Token: 0x0402779F RID: 161695
		[Token(Token = "0x402779F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _teamIcon;

		// Token: 0x040277A0 RID: 161696
		[Token(Token = "0x40277A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementModelCollector;

		// Token: 0x040277A1 RID: 161697
		[Token(Token = "0x40277A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DE5 RID: 19941
		[Token(Token = "0x2004DE5")]
		public class NameCardShareTeamObjectModelCollector : CrossAppShareElementModelCollector
		{
			// Token: 0x170045FC RID: 17916
			// (get) Token: 0x0601DCF8 RID: 122104 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601DCF9 RID: 122105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170045FC")]
			public CrossAppShareImageModel teamIconModel
			{
				[Token(Token = "0x601DCF8")]
				[Address(RVA = "0x1755E80", Offset = "0x1754A80", VA = "0x181755E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601DCF9")]
				[Address(RVA = "0x1755EE0", Offset = "0x1754AE0", VA = "0x181755EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601DCFA RID: 122106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCFA")]
			[Address(RVA = "0x1755DA0", Offset = "0x17549A0", VA = "0x181755DA0")]
			public void InitCollector(NameCardV2ShareTeamObjectStartLayoutElement shareTeamObject)
			{
			}

			// Token: 0x0601DCFB RID: 122107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCFB")]
			[Address(RVA = "0x1755BE0", Offset = "0x17547E0", VA = "0x181755BE0", Slot = "5")]
			public override void CollectModel()
			{
			}

			// Token: 0x0601DCFC RID: 122108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DCFC")]
			[Address(RVA = "0x1755E20", Offset = "0x1754A20", VA = "0x181755E20")]
			public NameCardShareTeamObjectModelCollector()
			{
			}

			// Token: 0x040277A2 RID: 161698
			[Token(Token = "0x40277A2")]
			[FieldOffset(Offset = "0x28")]
			private NameCardV2ShareTeamObjectStartLayoutElement m_closure;

			// Token: 0x040277A4 RID: 161700
			[Token(Token = "0x40277A4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_teamIconModel;

			// Token: 0x040277A5 RID: 161701
			[Token(Token = "0x40277A5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_teamIconModel;

			// Token: 0x040277A6 RID: 161702
			[Token(Token = "0x40277A6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InitCollector;

			// Token: 0x040277A7 RID: 161703
			[Token(Token = "0x40277A7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CollectModel;

			// Token: 0x040277A8 RID: 161704
			[Token(Token = "0x40277A8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
