using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003744 RID: 14148
	[Token(Token = "0x2003744")]
	public class UIPayCostCheckContent : MonoBehaviour
	{
		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x060167AB RID: 92075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060167AC RID: 92076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035DE")]
		public Action onConfirm
		{
			[Token(Token = "0x60167AB")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60167AC")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x060167AD RID: 92077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060167AE RID: 92078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035DF")]
		public Action onCancel
		{
			[Token(Token = "0x60167AD")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60167AE")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060167AF RID: 92079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167AF")]
		[Address(RVA = "0xEEE450", Offset = "0xEED050", VA = "0x180EEE450")]
		public void Init()
		{
		}

		// Token: 0x060167B0 RID: 92080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B0")]
		[Address(RVA = "0xEEE5E0", Offset = "0xEED1E0", VA = "0x180EEE5E0")]
		public void Show()
		{
		}

		// Token: 0x060167B1 RID: 92081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B1")]
		[Address(RVA = "0xEEE410", Offset = "0xEED010", VA = "0x180EEE410")]
		public void Hide()
		{
		}

		// Token: 0x060167B2 RID: 92082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B2")]
		[Address(RVA = "0xEEE3F0", Offset = "0xEECFF0", VA = "0x180EEE3F0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x060167B3 RID: 92083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B3")]
		[Address(RVA = "0xEEE3D0", Offset = "0xEECFD0", VA = "0x180EEE3D0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x060167B4 RID: 92084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167B4")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIPayCostCheckContent()
		{
		}

		// Token: 0x0401B13A RID: 110906
		[Token(Token = "0x401B13A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _floatPanel;

		// Token: 0x0401B13B RID: 110907
		[Token(Token = "0x401B13B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;
	}
}
