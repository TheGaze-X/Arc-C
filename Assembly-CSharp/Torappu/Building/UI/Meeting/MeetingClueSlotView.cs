using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D6F RID: 7535
	[Token(Token = "0x2001D6F")]
	public class MeetingClueSlotView : MonoBehaviour
	{
		// Token: 0x0600BA29 RID: 47657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA29")]
		[Address(RVA = "0x337C5A0", Offset = "0x337B1A0", VA = "0x18337C5A0")]
		public void Setup(IMeetingClue clue, Action<int> clicked, string iconHubPath, bool keepSelection = false, bool showTrackPoint = false)
		{
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2A")]
		[Address(RVA = "0x337C850", Offset = "0x337B450", VA = "0x18337C850")]
		private void _RefreshRestTimeLabel()
		{
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2B")]
		[Address(RVA = "0x337C560", Offset = "0x337B160", VA = "0x18337C560")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x00045B10 File Offset: 0x00043D10
		[Token(Token = "0x17001698")]
		public int slotIndex
		{
			[Token(Token = "0x600BA2C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2D")]
		[Address(RVA = "0x337C540", Offset = "0x337B140", VA = "0x18337C540")]
		public void OnPressed()
		{
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public MeetingClueSlotView()
		{
		}

		// Token: 0x0400B906 RID: 47366
		[Token(Token = "0x400B906")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _slotIndex;

		// Token: 0x0400B907 RID: 47367
		[Token(Token = "0x400B907")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0400B908 RID: 47368
		[Token(Token = "0x400B908")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _cluePanel;

		// Token: 0x0400B909 RID: 47369
		[Token(Token = "0x400B909")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectObject;

		// Token: 0x0400B90A RID: 47370
		[Token(Token = "0x400B90A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _unselectObject;

		// Token: 0x0400B90B RID: 47371
		[Token(Token = "0x400B90B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text[] _numberLabels;

		// Token: 0x0400B90C RID: 47372
		[Token(Token = "0x400B90C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _clueImage;

		// Token: 0x0400B90D RID: 47373
		[Token(Token = "0x400B90D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _clueIcon;

		// Token: 0x0400B90E RID: 47374
		[Token(Token = "0x400B90E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MeetingClueRestTimeLabel _restTimeLabel;

		// Token: 0x0400B90F RID: 47375
		[Token(Token = "0x400B90F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x0400B910 RID: 47376
		[Token(Token = "0x400B910")]
		[FieldOffset(Offset = "0x68")]
		private Action<int> m_clicked;

		// Token: 0x0400B911 RID: 47377
		[Token(Token = "0x400B911")]
		[FieldOffset(Offset = "0x70")]
		private IMeetingClue m_clue;
	}
}
