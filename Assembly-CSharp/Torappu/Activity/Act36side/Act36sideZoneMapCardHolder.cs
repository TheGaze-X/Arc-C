using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007465 RID: 29797
	[Token(Token = "0x2007465")]
	public class Act36sideZoneMapCardHolder : StageCustomZoneMap
	{
		// Token: 0x17006328 RID: 25384
		// (get) Token: 0x0602A083 RID: 172163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006328")]
		public List<Act36sideZoneMapCardHolder.StageLine> stageLineList
		{
			[Token(Token = "0x602A083")]
			[Address(RVA = "0x25A1D30", Offset = "0x25A0930", VA = "0x1825A1D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006329 RID: 25385
		// (get) Token: 0x0602A084 RID: 172164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006329")]
		public List<Act36sideZoneMapCardFrontView> cardList
		{
			[Token(Token = "0x602A084")]
			[Address(RVA = "0x25A1C70", Offset = "0x25A0870", VA = "0x1825A1C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A085 RID: 172165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A085")]
		[Address(RVA = "0x25A1B70", Offset = "0x25A0770", VA = "0x1825A1B70")]
		public Act36sideZoneMapCardHolder()
		{
		}

		// Token: 0x0403C4D3 RID: 246995
		[Token(Token = "0x403C4D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Act36sideZoneMapCardHolder.StageLine> _stageLines;

		// Token: 0x0403C4D4 RID: 246996
		[Token(Token = "0x403C4D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act36sideZoneMapCardFrontView> _cardList;

		// Token: 0x0403C4D5 RID: 246997
		[Token(Token = "0x403C4D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageLineList;

		// Token: 0x0403C4D6 RID: 246998
		[Token(Token = "0x403C4D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x0403C4D7 RID: 246999
		[Token(Token = "0x403C4D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007466 RID: 29798
		[Token(Token = "0x2007466")]
		[Serializable]
		public struct StageLine
		{
			// Token: 0x0403C4D8 RID: 247000
			[Token(Token = "0x403C4D8")]
			[FieldOffset(Offset = "0x0")]
			public string fromStage;

			// Token: 0x0403C4D9 RID: 247001
			[Token(Token = "0x403C4D9")]
			[FieldOffset(Offset = "0x8")]
			public string toStage;
		}
	}
}
