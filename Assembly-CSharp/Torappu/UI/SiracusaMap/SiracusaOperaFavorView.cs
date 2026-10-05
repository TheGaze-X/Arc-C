using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F44 RID: 16196
	[Token(Token = "0x2003F44")]
	public class SiracusaOperaFavorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019262 RID: 103010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019262")]
		[Address(RVA = "0x11DB8B0", Offset = "0x11DA4B0", VA = "0x1811DB8B0")]
		public void Render(int totalCount, int currentCount, bool isAllRelease)
		{
		}

		// Token: 0x06019263 RID: 103011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019263")]
		[Address(RVA = "0x11DBB70", Offset = "0x11DA770", VA = "0x1811DBB70")]
		public SiracusaOperaFavorView()
		{
		}

		// Token: 0x0401F288 RID: 127624
		[Token(Token = "0x401F288")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _currentCount;

		// Token: 0x0401F289 RID: 127625
		[Token(Token = "0x401F289")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxCount;

		// Token: 0x0401F28A RID: 127626
		[Token(Token = "0x401F28A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0401F28B RID: 127627
		[Token(Token = "0x401F28B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainTimeUnit;

		// Token: 0x0401F28C RID: 127628
		[Token(Token = "0x401F28C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _remainTimePart;

		// Token: 0x0401F28D RID: 127629
		[Token(Token = "0x401F28D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0401F28E RID: 127630
		[Token(Token = "0x401F28E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F28F RID: 127631
		[Token(Token = "0x401F28F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
