using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public class UICommonEditorMonoObject : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public Image image
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public Text signLeftUp
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public Text signLeftDown
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x55AC900", Offset = "0x55AB500", VA = "0x1855AC900")]
		public void Init(string name, Vector3 position)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICommonEditorMonoObject()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _signLeftUp;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _signLeftDown;
	}
}
