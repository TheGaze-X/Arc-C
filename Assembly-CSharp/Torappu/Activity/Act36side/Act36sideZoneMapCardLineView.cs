using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007467 RID: 29799
	[Token(Token = "0x2007467")]
	public class Act36sideZoneMapCardLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A086 RID: 172166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A086")]
		[Address(RVA = "0x25A1DF0", Offset = "0x25A09F0", VA = "0x1825A1DF0")]
		public void Init(string stageId, Act36sideZoneMapContainer.LineMeta lineMeta)
		{
		}

		// Token: 0x0602A087 RID: 172167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A087")]
		[Address(RVA = "0x25A2020", Offset = "0x25A0C20", VA = "0x1825A2020")]
		public void Render(ZoneViewModel zoneViewModel)
		{
		}

		// Token: 0x0602A088 RID: 172168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A088")]
		[Address(RVA = "0x25A2180", Offset = "0x25A0D80", VA = "0x1825A2180")]
		private void _RenderActive(bool isActive)
		{
		}

		// Token: 0x0602A089 RID: 172169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A089")]
		[Address(RVA = "0x25A2210", Offset = "0x25A0E10", VA = "0x1825A2210")]
		public Act36sideZoneMapCardLineView()
		{
		}

		// Token: 0x0403C4DA RID: 247002
		[Token(Token = "0x403C4DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0403C4DB RID: 247003
		[Token(Token = "0x403C4DB")]
		[FieldOffset(Offset = "0x20")]
		private string m_stageId;

		// Token: 0x0403C4DC RID: 247004
		[Token(Token = "0x403C4DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403C4DD RID: 247005
		[Token(Token = "0x403C4DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C4DE RID: 247006
		[Token(Token = "0x403C4DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderActive;

		// Token: 0x0403C4DF RID: 247007
		[Token(Token = "0x403C4DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
