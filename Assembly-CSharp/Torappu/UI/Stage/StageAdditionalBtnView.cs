using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006949 RID: 26953
	[Token(Token = "0x2006949")]
	public abstract class StageAdditionalBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026964 RID: 158052
		[Token(Token = "0x6026964")]
		public abstract bool OnUpdate(ZoneViewModel model);

		// Token: 0x06026965 RID: 158053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026965")]
		[Address(RVA = "0x21A7DB0", Offset = "0x21A69B0", VA = "0x1821A7DB0")]
		protected StageAdditionalBtnView()
		{
		}

		// Token: 0x0403670D RID: 222989
		[Token(Token = "0x403670D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
