using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007512 RID: 29970
	[Token(Token = "0x2007512")]
	public class Act25sideResearchAddTokenView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3CF RID: 173007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CF")]
		[Address(RVA = "0x25E0120", Offset = "0x25DED20", VA = "0x1825E0120")]
		public void Render(int initCount, int addCount, int maxCount, bool showMax)
		{
		}

		// Token: 0x0602A3D0 RID: 173008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D0")]
		[Address(RVA = "0x25E02D0", Offset = "0x25DEED0", VA = "0x1825E02D0")]
		private void _ShowAdd(int initCount, int addCount, int maxCount)
		{
		}

		// Token: 0x0602A3D1 RID: 173009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D1")]
		[Address(RVA = "0x25E0650", Offset = "0x25DF250", VA = "0x1825E0650")]
		private void _ShowMax(int maxCount)
		{
		}

		// Token: 0x0602A3D2 RID: 173010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D2")]
		[Address(RVA = "0x25E00A0", Offset = "0x25DECA0", VA = "0x1825E00A0")]
		public void OnDismiss()
		{
		}

		// Token: 0x0602A3D3 RID: 173011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3D3")]
		[Address(RVA = "0x25E0820", Offset = "0x25DF420", VA = "0x1825E0820")]
		public Act25sideResearchAddTokenView()
		{
		}

		// Token: 0x0403CB48 RID: 248648
		[Token(Token = "0x403CB48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CB49 RID: 248649
		[Token(Token = "0x403CB49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _maxAnim;

		// Token: 0x0403CB4A RID: 248650
		[Token(Token = "0x403CB4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _currentCount;

		// Token: 0x0403CB4B RID: 248651
		[Token(Token = "0x403CB4B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _maxCount;

		// Token: 0x0403CB4C RID: 248652
		[Token(Token = "0x403CB4C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _upTip;

		// Token: 0x0403CB4D RID: 248653
		[Token(Token = "0x403CB4D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _maxTip;

		// Token: 0x0403CB4E RID: 248654
		[Token(Token = "0x403CB4E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _numAnimDelay;

		// Token: 0x0403CB4F RID: 248655
		[Token(Token = "0x403CB4F")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _numDuration;

		// Token: 0x0403CB50 RID: 248656
		[Token(Token = "0x403CB50")]
		[FieldOffset(Offset = "0x60")]
		private Sequence m_sequence;

		// Token: 0x0403CB51 RID: 248657
		[Token(Token = "0x403CB51")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action onDismiss;

		// Token: 0x0403CB52 RID: 248658
		[Token(Token = "0x403CB52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CB53 RID: 248659
		[Token(Token = "0x403CB53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShowAdd;

		// Token: 0x0403CB54 RID: 248660
		[Token(Token = "0x403CB54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowMax;

		// Token: 0x0403CB55 RID: 248661
		[Token(Token = "0x403CB55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDismiss;

		// Token: 0x0403CB56 RID: 248662
		[Token(Token = "0x403CB56")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
