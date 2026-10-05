using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using XLua;

namespace Torappu.Building.DIY
{
	// Token: 0x0200184C RID: 6220
	[Token(Token = "0x200184C")]
	public class DIYFurnitureMusicController : SingletonInScene<DIYFurnitureMusicController>, IDisposable
	{
		// Token: 0x06009D49 RID: 40265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D49")]
		[Address(RVA = "0x317D130", Offset = "0x317BD30", VA = "0x18317D130")]
		private DIYFurnitureMusicController()
		{
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4A")]
		[Address(RVA = "0x317CD30", Offset = "0x317B930", VA = "0x18317CD30")]
		public void PlayFurnitureMusic(string musicId)
		{
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4B")]
		[Address(RVA = "0x317CF10", Offset = "0x317BB10", VA = "0x18317CF10")]
		public void StopFurnitureMusic()
		{
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4C")]
		[Address(RVA = "0x317CC90", Offset = "0x317B890", VA = "0x18317CC90", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D4D")]
		[Address(RVA = "0x317CFB0", Offset = "0x317BBB0", VA = "0x18317CFB0")]
		private void _PlayFurnitureMusicWithDucking(string musicId)
		{
		}

		// Token: 0x04009403 RID: 37891
		[Token(Token = "0x4009403")]
		[FieldOffset(Offset = "0x18")]
		private UIMusicDuckingHelper m_musicDuckingHelper;

		// Token: 0x04009404 RID: 37892
		[Token(Token = "0x4009404")]
		[FieldOffset(Offset = "0x20")]
		private AudioMusicGroupHandler m_musicGroupHandler;

		// Token: 0x04009405 RID: 37893
		[Token(Token = "0x4009405")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedMusicId;

		// Token: 0x04009406 RID: 37894
		[Token(Token = "0x4009406")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04009407 RID: 37895
		[Token(Token = "0x4009407")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayFurnitureMusic;

		// Token: 0x04009408 RID: 37896
		[Token(Token = "0x4009408")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StopFurnitureMusic;

		// Token: 0x04009409 RID: 37897
		[Token(Token = "0x4009409")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400940A RID: 37898
		[Token(Token = "0x400940A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayFurnitureMusicWithDucking;
	}
}
