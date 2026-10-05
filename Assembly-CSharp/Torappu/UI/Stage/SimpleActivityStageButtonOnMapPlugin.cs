using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006780 RID: 26496
	[Token(Token = "0x2006780")]
	public abstract class SimpleActivityStageButtonOnMapPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602602E RID: 155694
		[Token(Token = "0x602602E")]
		public abstract void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected);

		// Token: 0x0602602F RID: 155695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602602F")]
		[Address(RVA = "0x20FC9D0", Offset = "0x20FB5D0", VA = "0x1820FC9D0")]
		protected SimpleActivityStageButtonOnMapPlugin()
		{
		}

		// Token: 0x0403578E RID: 219022
		[Token(Token = "0x403578E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
