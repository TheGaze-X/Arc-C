using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B31 RID: 19249
	[Token(Token = "0x2004B31")]
	public class HomeTrackPointWrapper : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601CFF2 RID: 118770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF2")]
		[Address(RVA = "0x1679AF0", Offset = "0x16786F0", VA = "0x181679AF0")]
		public void Render(ITrackPointModel model)
		{
		}

		// Token: 0x0601CFF3 RID: 118771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFF3")]
		[Address(RVA = "0x1679B90", Offset = "0x1678790", VA = "0x181679B90")]
		public HomeTrackPointWrapper()
		{
		}

		// Token: 0x04026080 RID: 155776
		[Token(Token = "0x4026080")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HomeTrackPointItem _item;

		// Token: 0x04026081 RID: 155777
		[Token(Token = "0x4026081")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026082 RID: 155778
		[Token(Token = "0x4026082")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
