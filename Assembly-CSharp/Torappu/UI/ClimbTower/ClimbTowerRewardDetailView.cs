using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C5E RID: 23646
	[Token(Token = "0x2005C5E")]
	public class ClimbTowerRewardDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602242A RID: 140330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602242A")]
		[Address(RVA = "0x1CC1680", Offset = "0x1CC0280", VA = "0x181CC1680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602242B RID: 140331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602242B")]
		[Address(RVA = "0x1CC13E0", Offset = "0x1CBFFE0", VA = "0x181CC13E0")]
		public void Render()
		{
		}

		// Token: 0x0602242C RID: 140332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602242C")]
		[Address(RVA = "0x1CC17C0", Offset = "0x1CC03C0", VA = "0x181CC17C0")]
		public ClimbTowerRewardDetailView()
		{
		}

		// Token: 0x0402F0A3 RID: 192675
		[Token(Token = "0x402F0A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLowerItemName;

		// Token: 0x0402F0A4 RID: 192676
		[Token(Token = "0x402F0A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textHigherItemName;

		// Token: 0x0402F0A5 RID: 192677
		[Token(Token = "0x402F0A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _columnContainer;

		// Token: 0x0402F0A6 RID: 192678
		[Token(Token = "0x402F0A6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0402F0A7 RID: 192679
		[Token(Token = "0x402F0A7")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerRewardDetailView.Adapter m_adapter;

		// Token: 0x0402F0A8 RID: 192680
		[Token(Token = "0x402F0A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F0A9 RID: 192681
		[Token(Token = "0x402F0A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F0AA RID: 192682
		[Token(Token = "0x402F0AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C5F RID: 23647
		[Token(Token = "0x2005C5F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x1700506D RID: 20589
			// (get) Token: 0x0602242D RID: 140333 RVA: 0x000BCD60 File Offset: 0x000BAF60
			[Token(Token = "0x1700506D")]
			public override int count
			{
				[Token(Token = "0x602242D")]
				[Address(RVA = "0x1CB8700", Offset = "0x1CB7300", VA = "0x181CB8700", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602242E RID: 140334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602242E")]
			[Address(RVA = "0x1CB8230", Offset = "0x1CB6E30", VA = "0x181CB8230")]
			public Adapter()
			{
			}

			// Token: 0x0602242F RID: 140335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602242F")]
			[Address(RVA = "0x1CB7F60", Offset = "0x1CB6B60", VA = "0x181CB7F60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F0AB RID: 192683
			[Token(Token = "0x402F0AB")]
			[FieldOffset(Offset = "0x20")]
			private List<ClimbTowerRewardInfo> m_rewardInfos;

			// Token: 0x0402F0AC RID: 192684
			[Token(Token = "0x402F0AC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F0AD RID: 192685
			[Token(Token = "0x402F0AD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F0AE RID: 192686
			[Token(Token = "0x402F0AE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
