using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.LitJson;

namespace YoStar.SDK.UI
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class NetStatusItem : MonoBehaviour
	{
		// Token: 0x06000958 RID: 2392 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5C66700", Offset = "0x5C65300", VA = "0x185C66700")]
		private void Awake()
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Update()
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x5C66C10", Offset = "0x5C65810", VA = "0x185C66C10")]
		public void StartAnimator()
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x5C66C50", Offset = "0x5C65850", VA = "0x185C66C50")]
		public void StopAnimator()
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x5C668E0", Offset = "0x5C654E0", VA = "0x185C668E0")]
		public void SetupDataSource(JsonData jsonData)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x5C66880", Offset = "0x5C65480", VA = "0x185C66880")]
		private IEnumerator ForceUIUpdate()
		{
			return null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public NetStatusItem()
		{
		}

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x18")]
		private Animator animator;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x20")]
		private Image image;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x28")]
		private Text text;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x30")]
		private Text title;
	}
}
