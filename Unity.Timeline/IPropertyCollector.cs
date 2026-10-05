using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public interface IPropertyCollector
	{
		// Token: 0x06000332 RID: 818
		[Token(Token = "0x6000332")]
		void PushActiveGameObject(GameObject gameObject);

		// Token: 0x06000333 RID: 819
		[Token(Token = "0x6000333")]
		void PopActiveGameObject();

		// Token: 0x06000334 RID: 820
		[Token(Token = "0x6000334")]
		void AddFromClip(AnimationClip clip);

		// Token: 0x06000335 RID: 821
		[Token(Token = "0x6000335")]
		void AddFromClips(IEnumerable<AnimationClip> clips);

		// Token: 0x06000336 RID: 822
		[Token(Token = "0x6000336")]
		void AddFromName<T>(string name) where T : Component;

		// Token: 0x06000337 RID: 823
		[Token(Token = "0x6000337")]
		void AddFromName(string name);

		// Token: 0x06000338 RID: 824
		[Token(Token = "0x6000338")]
		void AddFromClip(GameObject obj, AnimationClip clip);

		// Token: 0x06000339 RID: 825
		[Token(Token = "0x6000339")]
		void AddFromClips(GameObject obj, IEnumerable<AnimationClip> clips);

		// Token: 0x0600033A RID: 826
		[Token(Token = "0x600033A")]
		void AddFromName<T>(GameObject obj, string name) where T : Component;

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600033B")]
		void AddFromName(GameObject obj, string name);

		// Token: 0x0600033C RID: 828
		[Token(Token = "0x600033C")]
		void AddFromName(Component component, string name);

		// Token: 0x0600033D RID: 829
		[Token(Token = "0x600033D")]
		void AddFromComponent(GameObject obj, Component component);

		// Token: 0x0600033E RID: 830
		[Token(Token = "0x600033E")]
		void AddObjectProperties(Object obj, AnimationClip clip);
	}
}
