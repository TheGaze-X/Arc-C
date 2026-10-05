using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200392E RID: 14638
	[Token(Token = "0x200392E")]
	public class ExposureTracker : IHotfixable
	{
		// Token: 0x06017231 RID: 94769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017231")]
		[Address(RVA = "0xF861B0", Offset = "0xF84DB0", VA = "0x180F861B0")]
		public ExposureTracker(RectTransform viewport, float threshold)
		{
		}

		// Token: 0x06017232 RID: 94770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017232")]
		[Address(RVA = "0xF85980", Offset = "0xF84580", VA = "0x180F85980")]
		public void Tick()
		{
		}

		// Token: 0x06017233 RID: 94771 RVA: 0x00094FE0 File Offset: 0x000931E0
		[Token(Token = "0x6017233")]
		[Address(RVA = "0xF85DE0", Offset = "0xF849E0", VA = "0x180F85DE0")]
		private float _CalculateExposure(RectTransform item)
		{
			return 0f;
		}

		// Token: 0x06017234 RID: 94772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017234")]
		[Address(RVA = "0xF85780", Offset = "0xF84380", VA = "0x180F85780")]
		public void Register(IExposure exposure)
		{
		}

		// Token: 0x06017235 RID: 94773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017235")]
		[Address(RVA = "0xF85D00", Offset = "0xF84900", VA = "0x180F85D00")]
		public void Unregister(IExposure exposure)
		{
		}

		// Token: 0x0401BEDF RID: 114399
		[Token(Token = "0x401BEDF")]
		public const float SHOP_ITEM_SHOW_THRESHOLD = 0.5f;

		// Token: 0x0401BEE0 RID: 114400
		[Token(Token = "0x401BEE0")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_viewport;

		// Token: 0x0401BEE1 RID: 114401
		[Token(Token = "0x401BEE1")]
		[FieldOffset(Offset = "0x18")]
		private float m_threshold;

		// Token: 0x0401BEE2 RID: 114402
		[Token(Token = "0x401BEE2")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, IExposure> m_IdRectDict;

		// Token: 0x0401BEE3 RID: 114403
		[Token(Token = "0x401BEE3")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_idToRemove;

		// Token: 0x0401BEE4 RID: 114404
		[Token(Token = "0x401BEE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401BEE5 RID: 114405
		[Token(Token = "0x401BEE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0401BEE6 RID: 114406
		[Token(Token = "0x401BEE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalculateExposure;

		// Token: 0x0401BEE7 RID: 114407
		[Token(Token = "0x401BEE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x0401BEE8 RID: 114408
		[Token(Token = "0x401BEE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Unregister;
	}
}
