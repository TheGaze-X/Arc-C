using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class UserCenterHeaderItemScript : MonoBehaviour
	{
		// Token: 0x06000974 RID: 2420 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5C6D660", Offset = "0x5C6C260", VA = "0x185C6D660")]
		private void Awake()
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5C6D960", Offset = "0x5C6C560", VA = "0x185C6D960")]
		private void Update()
		{
		}

		// Token: 0x170000B4 RID: 180
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B4")]
		public string NickName
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x5C6DE00", Offset = "0x5C6CA00", VA = "0x185C6DE00")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B5")]
		public string Uid
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x5C6DEB0", Offset = "0x5C6CAB0", VA = "0x185C6DEB0")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B6")]
		public string LogoName
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x5C6DD60", Offset = "0x5C6C960", VA = "0x185C6DD60")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000B7")]
		public string ButtonText
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x5C6DC90", Offset = "0x5C6C890", VA = "0x185C6DC90")]
			set
			{
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UserCenterHeaderItemScript()
		{
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x18")]
		private Text uidText;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x20")]
		private Text nickNameText;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x28")]
		private Image headerImage;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x30")]
		private Button switchButton;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x38")]
		public Action OnClick;
	}
}
