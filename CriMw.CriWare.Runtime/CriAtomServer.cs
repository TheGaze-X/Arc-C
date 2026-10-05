using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class CriAtomServer : CriMonoBehaviour
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700001B")]
		public static CriAtomServer instance
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x36D3C30", Offset = "0x36D2830", VA = "0x1836D3C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x36D3500", Offset = "0x36D2100", VA = "0x1836D3500")]
		public static void CreateInstance()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x36D3830", Offset = "0x36D2430", VA = "0x1836D3830")]
		public static void DestroyInstance()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x36D3400", Offset = "0x36D2000", VA = "0x1836D3400")]
		private void Awake()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x36D3B90", Offset = "0x36D2790", VA = "0x1836D3B90", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x36D3AB0", Offset = "0x36D26B0", VA = "0x1836D3AB0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x36D35C0", Offset = "0x36D21C0", VA = "0x1836D35C0", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ConsumePcmOutput()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x36D3900", Offset = "0x36D2500", VA = "0x1836D3900")]
		private void OnApplicationPause(bool appPause)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x36D3900", Offset = "0x36D2500", VA = "0x1836D3900")]
		private void ProcessApplicationPause(bool appPause)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x36CF000", Offset = "0x36CDC00", VA = "0x1836CF000")]
		public CriAtomServer()
		{
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private static CriAtomServer _instance;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> onApplicationPausePreProcess;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> onApplicationPausePostProcess;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		public static bool KeepPlayingSoundOnPause;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x9")]
		public static bool EnableAutoConsumePcmOutput;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xA")]
		public static bool EnableBackgroundPlayback_ANDROID;
	}
}
