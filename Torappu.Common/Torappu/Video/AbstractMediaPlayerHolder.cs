using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Video
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public abstract class AbstractMediaPlayerHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x5512640", Offset = "0x5511240", VA = "0x185512640")]
		public void PrepareVideo(string path)
		{
		}

		// Token: 0x0600073C RID: 1852
		[Token(Token = "0x600073C")]
		public abstract void Init();

		// Token: 0x0600073D RID: 1853
		[Token(Token = "0x600073D")]
		public abstract void Stop();

		// Token: 0x0600073E RID: 1854
		[Token(Token = "0x600073E")]
		public abstract void Play();

		// Token: 0x0600073F RID: 1855
		[Token(Token = "0x600073F")]
		public abstract void SetLoop(bool loop);

		// Token: 0x06000740 RID: 1856
		[Token(Token = "0x6000740")]
		public abstract bool IsAbleToPlay();

		// Token: 0x06000741 RID: 1857
		[Token(Token = "0x6000741")]
		public abstract AbstractMediaPlayerHolder.Status GetCurrentStatus();

		// Token: 0x06000742 RID: 1858
		[Token(Token = "0x6000742")]
		protected abstract void SetPath(string path);

		// Token: 0x06000743 RID: 1859
		[Token(Token = "0x6000743")]
		public abstract void AddListener(Action<AbstractMediaPlayerHolder.Status> onReadyEvent);

		// Token: 0x06000744 RID: 1860
		[Token(Token = "0x6000744")]
		public abstract void RemoveListener(Action<AbstractMediaPlayerHolder.Status> onReadyEvent);

		// Token: 0x06000745 RID: 1861
		[Token(Token = "0x6000745")]
		public abstract void SetVolume(float volume);

		// Token: 0x06000746 RID: 1862
		[Token(Token = "0x6000746")]
		public abstract void SetSize(Vector2 size, Vector2 toScreenSize);

		// Token: 0x06000747 RID: 1863 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x55126D0", Offset = "0x55112D0", VA = "0x1855126D0")]
		protected AbstractMediaPlayerHolder()
		{
		}

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate0 __Hotfix0_PrepareVideo;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000131 RID: 305
		[Token(Token = "0x2000131")]
		public enum Status
		{
			// Token: 0x0400063F RID: 1599
			[Token(Token = "0x400063F")]
			UNKNOWN,
			// Token: 0x04000640 RID: 1600
			[Token(Token = "0x4000640")]
			STOP,
			// Token: 0x04000641 RID: 1601
			[Token(Token = "0x4000641")]
			PREPARE,
			// Token: 0x04000642 RID: 1602
			[Token(Token = "0x4000642")]
			READY,
			// Token: 0x04000643 RID: 1603
			[Token(Token = "0x4000643")]
			PLAYING,
			// Token: 0x04000644 RID: 1604
			[Token(Token = "0x4000644")]
			PLAYEND,
			// Token: 0x04000645 RID: 1605
			[Token(Token = "0x4000645")]
			ERROR
		}
	}
}
