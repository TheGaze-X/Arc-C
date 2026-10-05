using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class TopSceneManager : MonoBehaviour
{
	// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x51C5AF0", Offset = "0x51C46F0", VA = "0x1851C5AF0")]
	private void Start()
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x51C5A10", Offset = "0x51C4610", VA = "0x1851C5A10")]
	private void Show()
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x51C5B40", Offset = "0x51C4740", VA = "0x1851C5B40")]
	public TopSceneManager()
	{
	}

	// Token: 0x04000096 RID: 150
	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x18")]
	public GameObject webview;

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x20")]
	public Text countDownText;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x28")]
	private int countDown;
}
