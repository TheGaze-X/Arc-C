using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041AD RID: 16813
	[Token(Token = "0x20041AD")]
	public class SandboxV2DungeonReadArchiveCurDayItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019EE4 RID: 106212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EE4")]
		[Address(RVA = "0x12DF240", Offset = "0x12DDE40", VA = "0x1812DF240")]
		public void Render(SandboxV2DungeonReadArchiveCurDayInfoItemData itemData)
		{
		}

		// Token: 0x06019EE5 RID: 106213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EE5")]
		[Address(RVA = "0x12DF4E0", Offset = "0x12DE0E0", VA = "0x1812DF4E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019EE6 RID: 106214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019EE6")]
		[Address(RVA = "0x12DF640", Offset = "0x12DE240", VA = "0x1812DF640")]
		public SandboxV2DungeonReadArchiveCurDayItemView()
		{
		}

		// Token: 0x04020A48 RID: 133704
		[Token(Token = "0x4020A48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtDayTitle;

		// Token: 0x04020A49 RID: 133705
		[Token(Token = "0x4020A49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtDayCount;

		// Token: 0x04020A4A RID: 133706
		[Token(Token = "0x4020A4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _apListContent;

		// Token: 0x04020A4B RID: 133707
		[Token(Token = "0x4020A4B")]
		[FieldOffset(Offset = "0x30")]
		private int m_day;

		// Token: 0x04020A4C RID: 133708
		[Token(Token = "0x4020A4C")]
		[FieldOffset(Offset = "0x34")]
		private bool m_isInited;

		// Token: 0x04020A4D RID: 133709
		[Token(Token = "0x4020A4D")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonReadArchiveCurDayInfoItemData m_cachedData;

		// Token: 0x04020A4E RID: 133710
		[Token(Token = "0x4020A4E")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2DungeonReadArchiveCurDayItemView.ApItemListAdapter m_adapter;

		// Token: 0x04020A4F RID: 133711
		[Token(Token = "0x4020A4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020A50 RID: 133712
		[Token(Token = "0x4020A50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020A51 RID: 133713
		[Token(Token = "0x4020A51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041AE RID: 16814
		[Token(Token = "0x20041AE")]
		private class ApItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06019EE7 RID: 106215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019EE7")]
			[Address(RVA = "0x12CC180", Offset = "0x12CAD80", VA = "0x1812CC180")]
			public ApItemListAdapter(SandboxV2DungeonReadArchiveCurDayItemView closure)
			{
			}

			// Token: 0x17003DC1 RID: 15809
			// (get) Token: 0x06019EE8 RID: 106216 RVA: 0x0009FC30 File Offset: 0x0009DE30
			[Token(Token = "0x17003DC1")]
			public override int count
			{
				[Token(Token = "0x6019EE8")]
				[Address(RVA = "0x12CC280", Offset = "0x12CAE80", VA = "0x1812CC280", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019EE9 RID: 106217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019EE9")]
			[Address(RVA = "0x12CBF50", Offset = "0x12CAB50", VA = "0x1812CBF50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020A52 RID: 133714
			[Token(Token = "0x4020A52")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonReadArchiveCurDayItemView m_closure;

			// Token: 0x04020A53 RID: 133715
			[Token(Token = "0x4020A53")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020A54 RID: 133716
			[Token(Token = "0x4020A54")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020A55 RID: 133717
			[Token(Token = "0x4020A55")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
