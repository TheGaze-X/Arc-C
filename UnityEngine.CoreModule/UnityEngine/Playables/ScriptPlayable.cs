using System;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> where T : class, IPlayableBehaviour, new()
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x170002FE")]
		public static ScriptPlayable<T> Null
		{
			[Token(Token = "0x6000F58")]
			get
			{
				return default(ScriptPlayable<T>);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000F59")]
		public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
		{
			return default(ScriptPlayable<T>);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000F5A")]
		public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
		{
			return default(ScriptPlayable<T>);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000F5B")]
		private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5C")]
		private static object CreateScriptInstance()
		{
			return null;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5D")]
		private static object CloneScriptInstance(IPlayableBehaviour source)
		{
			return null;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5E")]
		private static object CloneScriptInstanceFromEngineObject(Object source)
		{
			return null;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F5F")]
		private static object CloneScriptInstanceFromIClonable(ICloneable source)
		{
			return null;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F60")]
		internal ScriptPlayable(PlayableHandle handle)
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000F61")]
		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F62")]
		public T GetBehaviour()
		{
			return null;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000F63")]
		public static implicit operator Playable(ScriptPlayable<T> playable)
		{
			return default(Playable);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000F64")]
		public static explicit operator ScriptPlayable<T>(Playable playable)
		{
			return default(ScriptPlayable<T>);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x6000F65")]
		public bool Equals(ScriptPlayable<T> other)
		{
			return default(bool);
		}

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ScriptPlayable<T> m_NullPlayable;
	}
}
