using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D72 RID: 7538
	[Token(Token = "0x2001D72")]
	public class MeetingFloatStateCornerView : MonoBehaviour
	{
		// Token: 0x0600BA3B RID: 47675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3B")]
		[Address(RVA = "0x337DC80", Offset = "0x337C880", VA = "0x18337DC80")]
		public void Setup(IMeetingSession session, RoomSlotModel roomSlotModel)
		{
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3C")]
		[Address(RVA = "0x337E010", Offset = "0x337CC10", VA = "0x18337E010")]
		private void _RefreshStorageClueNumber()
		{
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3D")]
		[Address(RVA = "0x337E320", Offset = "0x337CF20", VA = "0x18337E320")]
		private void _SetupCharacterView(IMeetingStationaryCharacter character, MeetingFloatStateCornerView.CharacterView view)
		{
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3E")]
		[Address(RVA = "0x337E3E0", Offset = "0x337CFE0", VA = "0x18337E3E0")]
		private void _UpdateProgressBar()
		{
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3F")]
		[Address(RVA = "0x337DFC0", Offset = "0x337CBC0", VA = "0x18337DFC0")]
		private void Update()
		{
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA40")]
		[Address(RVA = "0x337DAD0", Offset = "0x337C6D0", VA = "0x18337DAD0")]
		public void OnBGButtonPressed()
		{
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA41")]
		[Address(RVA = "0x337E5C0", Offset = "0x337D1C0", VA = "0x18337E5C0")]
		public MeetingFloatStateCornerView()
		{
		}

		// Token: 0x0400B921 RID: 47393
		[Token(Token = "0x400B921")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeetingFloatStateCornerView.CharacterView _charView0;

		// Token: 0x0400B922 RID: 47394
		[Token(Token = "0x400B922")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeetingFloatStateCornerView.CharacterView _charView1;

		// Token: 0x0400B923 RID: 47395
		[Token(Token = "0x400B923")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _storageClueNumber;

		// Token: 0x0400B924 RID: 47396
		[Token(Token = "0x400B924")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _storageClueCapacity;

		// Token: 0x0400B925 RID: 47397
		[Token(Token = "0x400B925")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0400B926 RID: 47398
		[Token(Token = "0x400B926")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _progressBarRoot;

		// Token: 0x0400B927 RID: 47399
		[Token(Token = "0x400B927")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _updateInterval;

		// Token: 0x0400B928 RID: 47400
		[Token(Token = "0x400B928")]
		[FieldOffset(Offset = "0x50")]
		private IMeetingSession m_session;

		// Token: 0x0400B929 RID: 47401
		[Token(Token = "0x400B929")]
		[FieldOffset(Offset = "0x58")]
		private float m_timer;

		// Token: 0x0400B92A RID: 47402
		[Token(Token = "0x400B92A")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_storageFull;

		// Token: 0x0400B92B RID: 47403
		[Token(Token = "0x400B92B")]
		[FieldOffset(Offset = "0x5D")]
		private bool m_needUpdateProgress;

		// Token: 0x0400B92C RID: 47404
		[Token(Token = "0x400B92C")]
		[FieldOffset(Offset = "0x60")]
		private RoomSlotModel m_roomSlotModel;

		// Token: 0x02001D73 RID: 7539
		[Token(Token = "0x2001D73")]
		[Serializable]
		public class CharacterView
		{
			// Token: 0x0600BA42 RID: 47682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BA42")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharacterView()
			{
			}

			// Token: 0x0400B92D RID: 47405
			[Token(Token = "0x400B92D")]
			[FieldOffset(Offset = "0x10")]
			public Image characterImage;

			// Token: 0x0400B92E RID: 47406
			[Token(Token = "0x400B92E")]
			[FieldOffset(Offset = "0x18")]
			public Image emptyImage;
		}
	}
}
