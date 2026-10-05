using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051EF RID: 20975
	[Token(Token = "0x20051EF")]
	public abstract class RoguelikeDiceResultViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x0601EF82 RID: 126850
		[Token(Token = "0x17004851")]
		public abstract DiceResultShowType diceResultShowType { [Token(Token = "0x601EF82")] get; }

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x0601EF83 RID: 126851
		[Token(Token = "0x17004852")]
		public abstract RoguelikeDiceResultViewBase.DiceResultViewModelCreator diceResultViewModelCreator { [Token(Token = "0x601EF83")] get; }

		// Token: 0x0601EF84 RID: 126852
		[Token(Token = "0x601EF84")]
		public abstract void Render(RoguelikeDiceResultViewModel model);

		// Token: 0x0601EF85 RID: 126853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF85")]
		[Address(RVA = "0x18B2D10", Offset = "0x18B1910", VA = "0x1818B2D10")]
		protected RoguelikeDiceResultViewBase()
		{
		}

		// Token: 0x040298F6 RID: 170230
		[Token(Token = "0x40298F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051F0 RID: 20976
		// (Invoke) Token: 0x0601EF87 RID: 126855
		[Token(Token = "0x20051F0")]
		public delegate RoguelikeDiceResultViewModel DiceResultViewModelCreator();
	}
}
