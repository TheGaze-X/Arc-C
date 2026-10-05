using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FA3 RID: 8099
	[Token(Token = "0x2001FA3")]
	public class AudioClickPlayer : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IHotfixable
	{
		// Token: 0x0600C934 RID: 51508 RVA: 0x000491E8 File Offset: 0x000473E8
		[Token(Token = "0x600C934")]
		[Address(RVA = "0x349DE30", Offset = "0x349CA30", VA = "0x18349DE30")]
		private bool _ShowCustomFields()
		{
			return default(bool);
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x00049200 File Offset: 0x00047400
		[Token(Token = "0x600C935")]
		[Address(RVA = "0x349DE90", Offset = "0x349CA90", VA = "0x18349DE90")]
		private bool _ShowInternalFields()
		{
			return default(bool);
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x00049218 File Offset: 0x00047418
		[Token(Token = "0x600C936")]
		[Address(RVA = "0x349DDD0", Offset = "0x349C9D0", VA = "0x18349DDD0")]
		private bool _ShowBuildingSoundFields()
		{
			return default(bool);
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C937")]
		[Address(RVA = "0x349DC00", Offset = "0x349C800", VA = "0x18349DC00")]
		private void _OnTargetButtonClicked()
		{
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C938")]
		[Address(RVA = "0x349DAC0", Offset = "0x349C6C0", VA = "0x18349DAC0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C939")]
		[Address(RVA = "0x349DB30", Offset = "0x349C730", VA = "0x18349DB30")]
		public UIButton.AudioModule _GenAudioInfo()
		{
			return null;
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C93A")]
		[Address(RVA = "0x349D9B0", Offset = "0x349C5B0", VA = "0x18349D9B0")]
		public UIButton.AudioModule GenFakeButtonOnlyAudioInfo()
		{
			return null;
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C93B")]
		[Address(RVA = "0x349DEF0", Offset = "0x349CAF0", VA = "0x18349DEF0")]
		public AudioClickPlayer()
		{
		}

		// Token: 0x0400CFE9 RID: 53225
		[Token(Token = "0x400CFE9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSoundType _soundType;

		// Token: 0x0400CFEA RID: 53226
		[Token(Token = "0x400CFEA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Inspect("_ShowInternalFields")]
		private UiInternalSoundType _internalType;

		// Token: 0x0400CFEB RID: 53227
		[Token(Token = "0x400CFEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("_ShowBuildingSoundFields")]
		private UiBuildingSoundType _buildingSoundType;

		// Token: 0x0400CFEC RID: 53228
		[Token(Token = "0x400CFEC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("_ShowCustomFields")]
		private string _signal;

		// Token: 0x0400CFED RID: 53229
		[Token(Token = "0x400CFED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("_ShowCustomFields")]
		private string _subsignal;

		// Token: 0x0400CFEE RID: 53230
		[Token(Token = "0x400CFEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ShowCustomFields;

		// Token: 0x0400CFEF RID: 53231
		[Token(Token = "0x400CFEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShowInternalFields;

		// Token: 0x0400CFF0 RID: 53232
		[Token(Token = "0x400CFF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowBuildingSoundFields;

		// Token: 0x0400CFF1 RID: 53233
		[Token(Token = "0x400CFF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTargetButtonClicked;

		// Token: 0x0400CFF2 RID: 53234
		[Token(Token = "0x400CFF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0400CFF3 RID: 53235
		[Token(Token = "0x400CFF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenAudioInfo;

		// Token: 0x0400CFF4 RID: 53236
		[Token(Token = "0x400CFF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenFakeButtonOnlyAudioInfo;

		// Token: 0x0400CFF5 RID: 53237
		[Token(Token = "0x400CFF5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
