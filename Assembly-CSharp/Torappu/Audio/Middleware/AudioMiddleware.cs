using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Audio.Middleware
{
	// Token: 0x02001FB4 RID: 8116
	[Token(Token = "0x2001FB4")]
	public abstract class AudioMiddleware
	{
		// Token: 0x0600C987 RID: 51591
		[Token(Token = "0x600C987")]
		public abstract void Init();

		// Token: 0x0600C988 RID: 51592
		[Token(Token = "0x600C988")]
		public abstract void ReloadBanks();

		// Token: 0x0600C989 RID: 51593
		[Token(Token = "0x600C989")]
		public abstract bool PlayEvent(string eventName, Vector3 worldPosition);

		// Token: 0x0600C98A RID: 51594
		[Token(Token = "0x600C98A")]
		public abstract void PlayEvent(string eventName, Vector3 worldPosition, out AudioAtom[] atoms);

		// Token: 0x0600C98B RID: 51595
		[Token(Token = "0x600C98B")]
		public abstract bool TestEvent(string eventName);

		// Token: 0x0600C98C RID: 51596
		[Token(Token = "0x600C98C")]
		public abstract void PreloadEvent(string persistTag, string eventName);

		// Token: 0x0600C98D RID: 51597
		[Token(Token = "0x600C98D")]
		public abstract void SetListenerPosition(Vector3 worldPosition, Quaternion worldRotation);

		// Token: 0x0600C98E RID: 51598
		[Token(Token = "0x600C98E")]
		public abstract void UnloadPreloadedAssets(string persistTag);

		// Token: 0x0600C98F RID: 51599
		[Token(Token = "0x600C98F")]
		public abstract void StopPreloadedEvents(string persistTag);

		// Token: 0x0600C990 RID: 51600
		[Token(Token = "0x600C990")]
		public abstract void Update(float deltaTime);

		// Token: 0x0600C991 RID: 51601
		[Token(Token = "0x600C991")]
		public abstract void StopAll(float fadeTime, bool exceptMusic);

		// Token: 0x0600C992 RID: 51602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C992")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AudioMiddleware()
		{
		}
	}
}
