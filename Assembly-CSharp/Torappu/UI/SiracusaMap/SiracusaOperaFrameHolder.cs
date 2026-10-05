using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F46 RID: 16198
	[Token(Token = "0x2003F46")]
	public class SiracusaOperaFrameHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019266 RID: 103014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019266")]
		[Address(RVA = "0x11DBF20", Offset = "0x11DAB20", VA = "0x1811DBF20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019267 RID: 103015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019267")]
		[Address(RVA = "0x11DBCE0", Offset = "0x11DA8E0", VA = "0x1811DBCE0")]
		public void Render(UIPage page, List<SiracusaOperaFrameViewModel> viewModelList, int selectIndex, bool needRefresh)
		{
		}

		// Token: 0x06019268 RID: 103016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019268")]
		[Address(RVA = "0x11DC050", Offset = "0x11DAC50", VA = "0x1811DC050")]
		public SiracusaOperaFrameHolder()
		{
		}

		// Token: 0x0401F293 RID: 127635
		[Token(Token = "0x401F293")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401F294 RID: 127636
		[Token(Token = "0x401F294")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIIntEvent _onSelectFrame;

		// Token: 0x0401F295 RID: 127637
		[Token(Token = "0x401F295")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401F296 RID: 127638
		[Token(Token = "0x401F296")]
		[FieldOffset(Offset = "0x30")]
		private SiracusaOperaFrameHolder.Adapter m_adapter;

		// Token: 0x0401F297 RID: 127639
		[Token(Token = "0x401F297")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F298 RID: 127640
		[Token(Token = "0x401F298")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F299 RID: 127641
		[Token(Token = "0x401F299")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F47 RID: 16199
		[Token(Token = "0x2003F47")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x06019269 RID: 103017 RVA: 0x0009D188 File Offset: 0x0009B388
			[Token(Token = "0x17003C25")]
			public override int count
			{
				[Token(Token = "0x6019269")]
				[Address(RVA = "0x11C5440", Offset = "0x11C4040", VA = "0x1811C5440", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601926A RID: 103018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601926A")]
			[Address(RVA = "0x11C4190", Offset = "0x11C2D90", VA = "0x1811C4190", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601926B RID: 103019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601926B")]
			[Address(RVA = "0x11C4FA0", Offset = "0x11C3BA0", VA = "0x1811C4FA0")]
			public Adapter()
			{
			}

			// Token: 0x0401F29A RID: 127642
			[Token(Token = "0x401F29A")]
			[FieldOffset(Offset = "0x20")]
			public List<SiracusaOperaFrameViewModel> viewModelList;

			// Token: 0x0401F29B RID: 127643
			[Token(Token = "0x401F29B")]
			[FieldOffset(Offset = "0x28")]
			public int selectIndex;

			// Token: 0x0401F29C RID: 127644
			[Token(Token = "0x401F29C")]
			[FieldOffset(Offset = "0x2C")]
			public bool needRefresh;

			// Token: 0x0401F29D RID: 127645
			[Token(Token = "0x401F29D")]
			[FieldOffset(Offset = "0x30")]
			public UIPage page;

			// Token: 0x0401F29E RID: 127646
			[Token(Token = "0x401F29E")]
			[FieldOffset(Offset = "0x38")]
			public UIIntEvent onClickFocus;

			// Token: 0x0401F29F RID: 127647
			[Token(Token = "0x401F29F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401F2A0 RID: 127648
			[Token(Token = "0x401F2A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401F2A1 RID: 127649
			[Token(Token = "0x401F2A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
