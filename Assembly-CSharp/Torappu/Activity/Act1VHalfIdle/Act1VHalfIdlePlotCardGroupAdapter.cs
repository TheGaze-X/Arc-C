using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007753 RID: 30547
	[Token(Token = "0x2007753")]
	public class Act1VHalfIdlePlotCardGroupAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x0602AE81 RID: 175745 RVA: 0x000DA688 File Offset: 0x000D8888
		[Token(Token = "0x170064A3")]
		public override int count
		{
			[Token(Token = "0x602AE81")]
			[Address(RVA = "0x26AFB00", Offset = "0x26AE700", VA = "0x1826AFB00", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170064A4 RID: 25764
		// (get) Token: 0x0602AE82 RID: 175746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AE83 RID: 175747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064A4")]
		public List<Act1VHalfidlePlotViewModel> dataSet
		{
			[Token(Token = "0x602AE82")]
			[Address(RVA = "0x26AFBB0", Offset = "0x26AE7B0", VA = "0x1826AFBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602AE83")]
			[Address(RVA = "0x26AFC10", Offset = "0x26AE810", VA = "0x1826AFC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AE84 RID: 175748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE84")]
		[Address(RVA = "0x26AF490", Offset = "0x26AE090", VA = "0x1826AF490", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602AE85 RID: 175749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE85")]
		[Address(RVA = "0x26AF2C0", Offset = "0x26ADEC0", VA = "0x1826AF2C0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AE86 RID: 175750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE86")]
		[Address(RVA = "0x26AFAA0", Offset = "0x26AE6A0", VA = "0x1826AFAA0")]
		public Act1VHalfIdlePlotCardGroupAdapter()
		{
		}

		// Token: 0x0403DDF4 RID: 253428
		[Token(Token = "0x403DDF4")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> onPlotSelectClick;

		// Token: 0x0403DDF6 RID: 253430
		[Token(Token = "0x403DDF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403DDF7 RID: 253431
		[Token(Token = "0x403DDF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dataSet;

		// Token: 0x0403DDF8 RID: 253432
		[Token(Token = "0x403DDF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_dataSet;

		// Token: 0x0403DDF9 RID: 253433
		[Token(Token = "0x403DDF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403DDFA RID: 253434
		[Token(Token = "0x403DDFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DDFB RID: 253435
		[Token(Token = "0x403DDFB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
