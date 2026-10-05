using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Notification
{
	// Token: 0x020047DE RID: 18398
	[Token(Token = "0x20047DE")]
	[CreateAssetMenu(menuName = "Torappu/UI/Notify View Holder")]
	[Serializable]
	public class UINotifyViewHolder : ScriptableObject
	{
		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x0601BD64 RID: 114020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004231")]
		public UITextNotifyView textNotifyView
		{
			[Token(Token = "0x601BD64")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0601BD65 RID: 114021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004232")]
		public UITextNotifyView lockNotifyView
		{
			[Token(Token = "0x601BD65")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0601BD66 RID: 114022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004233")]
		public UITextNotifyView unlockNotifyView
		{
			[Token(Token = "0x601BD66")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x0601BD67 RID: 114023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004234")]
		public UIMedalNotifyView multiMedalNotifyView
		{
			[Token(Token = "0x601BD67")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x0601BD68 RID: 114024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004235")]
		public UIMedalNotifyView singleMedalNotifyView
		{
			[Token(Token = "0x601BD68")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BD69 RID: 114025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD69")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public UINotifyViewHolder()
		{
		}

		// Token: 0x04024393 RID: 148371
		[Token(Token = "0x4024393")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UITextNotifyView _textNotify;

		// Token: 0x04024394 RID: 148372
		[Token(Token = "0x4024394")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UITextNotifyView _lockNotify;

		// Token: 0x04024395 RID: 148373
		[Token(Token = "0x4024395")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITextNotifyView _unlockNotify;

		// Token: 0x04024396 RID: 148374
		[Token(Token = "0x4024396")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIMedalNotifyView _multiMedalNotify;

		// Token: 0x04024397 RID: 148375
		[Token(Token = "0x4024397")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIMedalNotifyView _singleMedalNotify;
	}
}
