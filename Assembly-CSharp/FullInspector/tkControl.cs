using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C53 RID: 31827
	[Token(Token = "0x2007C53")]
	public abstract class tkControl<T, TContext> : tkIControl
	{
		// Token: 0x0602C7C7 RID: 182215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7C7")]
		protected fiGraphMetadata GetInstanceMetadata(fiGraphMetadata metadata)
		{
			return null;
		}

		// Token: 0x1700681E RID: 26654
		// (get) Token: 0x0602C7C8 RID: 182216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700681E")]
		public Type ContextType
		{
			[Token(Token = "0x602C7C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C7C9 RID: 182217
		[Token(Token = "0x602C7C9")]
		protected abstract T DoEdit(Rect rect, T obj, TContext context, fiGraphMetadata metadata);

		// Token: 0x0602C7CA RID: 182218
		[Token(Token = "0x602C7CA")]
		protected abstract float DoGetHeight(T obj, TContext context, fiGraphMetadata metadata);

		// Token: 0x0602C7CB RID: 182219 RVA: 0x000E04A8 File Offset: 0x000DE6A8
		[Token(Token = "0x602C7CB")]
		public virtual bool ShouldShow(T obj, TContext context, fiGraphMetadata metadata)
		{
			return default(bool);
		}

		// Token: 0x1700681F RID: 26655
		// (set) Token: 0x0602C7CC RID: 182220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700681F")]
		public tkStyle<T, TContext> Style
		{
			[Token(Token = "0x602C7CC")]
			set
			{
			}
		}

		// Token: 0x17006820 RID: 26656
		// (get) Token: 0x0602C7CD RID: 182221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C7CE RID: 182222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006820")]
		public List<tkStyle<T, TContext>> Styles
		{
			[Token(Token = "0x602C7CD")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C7CE")]
			set
			{
			}
		}

		// Token: 0x0602C7CF RID: 182223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7CF")]
		public T Edit(Rect rect, T obj, TContext context, fiGraphMetadata metadata)
		{
			return null;
		}

		// Token: 0x0602C7D0 RID: 182224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C7D0")]
		public object Edit(Rect rect, object obj, object context, fiGraphMetadata metadata)
		{
			return null;
		}

		// Token: 0x0602C7D1 RID: 182225 RVA: 0x000E04C0 File Offset: 0x000DE6C0
		[Token(Token = "0x602C7D1")]
		public float GetHeight(T obj, TContext context, fiGraphMetadata metadata)
		{
			return 0f;
		}

		// Token: 0x0602C7D2 RID: 182226 RVA: 0x000E04D8 File Offset: 0x000DE6D8
		[Token(Token = "0x602C7D2")]
		public float GetHeight(object obj, object context, fiGraphMetadata metadata)
		{
			return 0f;
		}

		// Token: 0x0602C7D3 RID: 182227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7D3")]
		private void InitializeId(ref int nextId)
		{
		}

		// Token: 0x17006821 RID: 26657
		// (get) Token: 0x0602C7D4 RID: 182228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006821")]
		protected virtual IEnumerable<tkIControl> NonMemberChildControls
		{
			[Token(Token = "0x602C7D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C7D5 RID: 182229 RVA: 0x000E04F0 File Offset: 0x000DE6F0
		[Token(Token = "0x602C7D5")]
		private static bool TryReadValue<TValue>(MemberInfo member, object context, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0602C7D6 RID: 182230 RVA: 0x000E0508 File Offset: 0x000DE708
		[Token(Token = "0x602C7D6")]
		private static bool TryGetMemberType(MemberInfo member, out Type memberType)
		{
			return default(bool);
		}

		// Token: 0x0602C7D7 RID: 182231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C7D7")]
		protected tkControl()
		{
		}

		// Token: 0x04040320 RID: 262944
		[Token(Token = "0x4040320")]
		[FieldOffset(Offset = "0x0")]
		private int _uniqueId;

		// Token: 0x04040321 RID: 262945
		[Token(Token = "0x4040321")]
		[FieldOffset(Offset = "0x0")]
		private List<tkStyle<T, TContext>> _styles;
	}
}
