using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075CF RID: 30159
	[Token(Token = "0x20075CF")]
	public abstract class Act24sideMissionAbstractDelegateTileView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A76C RID: 173932
		[Token(Token = "0x602A76C")]
		public abstract void Render(Act24SideData.MissionType type);

		// Token: 0x0602A76D RID: 173933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A76D")]
		[Address(RVA = "0x26239D0", Offset = "0x26225D0", VA = "0x1826239D0")]
		protected Act24sideMissionAbstractDelegateTileView()
		{
		}

		// Token: 0x0403D1D7 RID: 250327
		[Token(Token = "0x403D1D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
