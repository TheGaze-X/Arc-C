using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071D8 RID: 29144
	[Token(Token = "0x20071D8")]
	public class Act5D0MissionResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x06029589 RID: 169353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170061EC")]
		public Sprite backImg
		{
			[Token(Token = "0x6029589")]
			[Address(RVA = "0x24AA4A0", Offset = "0x24A90A0", VA = "0x1824AA4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x0602958A RID: 169354 RVA: 0x000D56F0 File Offset: 0x000D38F0
		[Token(Token = "0x170061ED")]
		public Color diffColor
		{
			[Token(Token = "0x602958A")]
			[Address(RVA = "0x24AA680", Offset = "0x24A9280", VA = "0x1824AA680")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x0602958B RID: 169355 RVA: 0x000D5708 File Offset: 0x000D3908
		[Token(Token = "0x170061EE")]
		public Color diffAppendColor
		{
			[Token(Token = "0x602958B")]
			[Address(RVA = "0x24AA600", Offset = "0x24A9200", VA = "0x1824AA600")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061EF RID: 25071
		// (get) Token: 0x0602958C RID: 169356 RVA: 0x000D5720 File Offset: 0x000D3920
		[Token(Token = "0x170061EF")]
		public Color titleColor
		{
			[Token(Token = "0x602958C")]
			[Address(RVA = "0x24AA780", Offset = "0x24A9380", VA = "0x1824AA780")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061F0 RID: 25072
		// (get) Token: 0x0602958D RID: 169357 RVA: 0x000D5738 File Offset: 0x000D3938
		[Token(Token = "0x170061F0")]
		public Color descColor
		{
			[Token(Token = "0x602958D")]
			[Address(RVA = "0x24AA580", Offset = "0x24A9180", VA = "0x1824AA580")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061F1 RID: 25073
		// (get) Token: 0x0602958E RID: 169358 RVA: 0x000D5750 File Offset: 0x000D3950
		[Token(Token = "0x170061F1")]
		public Color rewardCountColor
		{
			[Token(Token = "0x602958E")]
			[Address(RVA = "0x24AA700", Offset = "0x24A9300", VA = "0x1824AA700")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170061F2 RID: 25074
		// (get) Token: 0x0602958F RID: 169359 RVA: 0x000D5768 File Offset: 0x000D3968
		[Token(Token = "0x170061F2")]
		public Color crossColor
		{
			[Token(Token = "0x602958F")]
			[Address(RVA = "0x24AA500", Offset = "0x24A9100", VA = "0x1824AA500")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06029590 RID: 169360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029590")]
		[Address(RVA = "0x24AA440", Offset = "0x24A9040", VA = "0x1824AA440")]
		public Act5D0MissionResHolder()
		{
		}

		// Token: 0x0403B0D2 RID: 241874
		[Token(Token = "0x403B0D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _backImg;

		// Token: 0x0403B0D3 RID: 241875
		[Token(Token = "0x403B0D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _diffColor;

		// Token: 0x0403B0D4 RID: 241876
		[Token(Token = "0x403B0D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _diffAppendColor;

		// Token: 0x0403B0D5 RID: 241877
		[Token(Token = "0x403B0D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _titleColor;

		// Token: 0x0403B0D6 RID: 241878
		[Token(Token = "0x403B0D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _descColor;

		// Token: 0x0403B0D7 RID: 241879
		[Token(Token = "0x403B0D7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _rewardCountColor;

		// Token: 0x0403B0D8 RID: 241880
		[Token(Token = "0x403B0D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _crossColor;

		// Token: 0x0403B0D9 RID: 241881
		[Token(Token = "0x403B0D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_backImg;

		// Token: 0x0403B0DA RID: 241882
		[Token(Token = "0x403B0DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_diffColor;

		// Token: 0x0403B0DB RID: 241883
		[Token(Token = "0x403B0DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_diffAppendColor;

		// Token: 0x0403B0DC RID: 241884
		[Token(Token = "0x403B0DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_titleColor;

		// Token: 0x0403B0DD RID: 241885
		[Token(Token = "0x403B0DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_descColor;

		// Token: 0x0403B0DE RID: 241886
		[Token(Token = "0x403B0DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rewardCountColor;

		// Token: 0x0403B0DF RID: 241887
		[Token(Token = "0x403B0DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_crossColor;

		// Token: 0x0403B0E0 RID: 241888
		[Token(Token = "0x403B0E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
