using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015D3 RID: 5587
	[Token(Token = "0x20015D3")]
	public class DownloadUtil : MonoBehaviour
	{
		// Token: 0x06007ECF RID: 32463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ECF")]
		[Address(RVA = "0x2886E40", Offset = "0x2885A40", VA = "0x182886E40")]
		public static void DownloadFile(string url, Action<string, string> complete)
		{
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED0")]
		[Address(RVA = "0x2886F20", Offset = "0x2885B20", VA = "0x182886F20")]
		private void Start()
		{
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED1")]
		[Address(RVA = "0x2886F00", Offset = "0x2885B00", VA = "0x182886F00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007ED2")]
		[Address(RVA = "0x2886FC0", Offset = "0x2885BC0", VA = "0x182886FC0")]
		private IEnumerator _DoDownload()
		{
			return null;
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ED3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DownloadUtil()
		{
		}

		// Token: 0x0400807D RID: 32893
		[Token(Token = "0x400807D")]
		[FieldOffset(Offset = "0x18")]
		private string _url;

		// Token: 0x0400807E RID: 32894
		[Token(Token = "0x400807E")]
		[FieldOffset(Offset = "0x20")]
		private Action<string, string> _complete;
	}
}
