using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CBC RID: 7356
	[Token(Token = "0x2001CBC")]
	public class BuildingSMRoomInfoItem : MonoBehaviour
	{
		// Token: 0x0600B64B RID: 46667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64B")]
		[Address(RVA = "0x33053E0", Offset = "0x3303FE0", VA = "0x1833053E0")]
		public void Render(StationCharStructModel charModel)
		{
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64C")]
		[Address(RVA = "0x33058E0", Offset = "0x33044E0", VA = "0x1833058E0")]
		private void _UpdateManpower()
		{
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64D")]
		[Address(RVA = "0x3305BF0", Offset = "0x33047F0", VA = "0x183305BF0")]
		private void _UpdateWorkTimeCountDown()
		{
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64E")]
		[Address(RVA = "0x3305720", Offset = "0x3304320", VA = "0x183305720")]
		private void _OnWorkTimeUpdate(CountDownTask.TickValue value)
		{
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B64F")]
		[Address(RVA = "0x3305860", Offset = "0x3304460", VA = "0x183305860")]
		private IEnumerator _TryEnableAutoSlide()
		{
			return null;
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B650")]
		[Address(RVA = "0x33056E0", Offset = "0x33042E0", VA = "0x1833056E0")]
		private void Update()
		{
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B651")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingSMRoomInfoItem()
		{
		}

		// Token: 0x0400B334 RID: 45876
		[Token(Token = "0x400B334")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B335 RID: 45877
		[Token(Token = "0x400B335")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x0400B336 RID: 45878
		[Token(Token = "0x400B336")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B337 RID: 45879
		[Token(Token = "0x400B337")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCurAp;

		// Token: 0x0400B338 RID: 45880
		[Token(Token = "0x400B338")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMaxAp;

		// Token: 0x0400B339 RID: 45881
		[Token(Token = "0x400B339")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x0400B33A RID: 45882
		[Token(Token = "0x400B33A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAutoSlideRect _autoSlideRect;

		// Token: 0x0400B33B RID: 45883
		[Token(Token = "0x400B33B")]
		[FieldOffset(Offset = "0x50")]
		private CountDownTask m_mpCountDown;

		// Token: 0x0400B33C RID: 45884
		[Token(Token = "0x400B33C")]
		[FieldOffset(Offset = "0x58")]
		private CountDownTask m_workTimeCountDown;

		// Token: 0x0400B33D RID: 45885
		[Token(Token = "0x400B33D")]
		[FieldOffset(Offset = "0x60")]
		private StationCharStructModel m_cachedModel;

		// Token: 0x0400B33E RID: 45886
		[Token(Token = "0x400B33E")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;
	}
}
