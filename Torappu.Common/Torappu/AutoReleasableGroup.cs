using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class AutoReleasableGroup : IDisposable, IHotfixable
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x54FAEB0", Offset = "0x54F9AB0", VA = "0x1854FAEB0")]
		public bool IsDisposed()
		{
			return default(bool);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x54FBCB0", Offset = "0x54FA8B0", VA = "0x1854FBCB0")]
		public AutoReleasableGroup()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x54FAE20", Offset = "0x54F9A20", VA = "0x1854FAE20", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x54FB270", Offset = "0x54F9E70", VA = "0x1854FB270")]
		protected void TrackImpl(AutoReleasableGroup.EntryType type, object target)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x54FB4B0", Offset = "0x54FA0B0", VA = "0x1854FB4B0")]
		protected void UntrackImpl(object target)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x54FB5F0", Offset = "0x54FA1F0", VA = "0x1854FB5F0")]
		private static AutoReleasableGroup.Entry _FindEntry(List<AutoReleasableGroup.Entry> activeList, object target)
		{
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x54FB590", Offset = "0x54FA190", VA = "0x1854FB590")]
		private AutoReleasableGroup.Entry _CreateEntry()
		{
			return null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x54FB9D0", Offset = "0x54FA5D0", VA = "0x1854FB9D0")]
		private void _UntrackInactiveEntries()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x54FB770", Offset = "0x54FA370", VA = "0x1854FB770")]
		private static void _ReleaseAllEntries(List<AutoReleasableGroup.Entry> entries)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x54FACC0", Offset = "0x54F98C0", VA = "0x1854FACC0")]
		protected static bool CheckEntryAlive(AutoReleasableGroup.EntryType type, object target)
		{
			return default(bool);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x54FB0A0", Offset = "0x54F9CA0", VA = "0x1854FB0A0")]
		protected static void ReleaseEntry(AutoReleasableGroup.EntryType type, object target)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x54FB180", Offset = "0x54F9D80", VA = "0x1854FB180")]
		public void StartCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x54FB020", Offset = "0x54F9C20", VA = "0x1854FB020")]
		public void ReleaseCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x54FB3B0", Offset = "0x54F9FB0", VA = "0x1854FB3B0")]
		public void Track(Tween tween)
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x54FAF20", Offset = "0x54F9B20", VA = "0x1854FAF20")]
		public void KillAndUntrack(Tween tween)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x54FB430", Offset = "0x54FA030", VA = "0x1854FB430")]
		public void Track(AutoReleasableGroup.ICustom custom)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x54FAFA0", Offset = "0x54F9BA0", VA = "0x1854FAFA0")]
		public void ReleaseAndUntrack(AutoReleasableGroup.ICustom custom)
		{
		}

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x10")]
		private GenericPool<List<AutoReleasableGroup.Entry>>.Ref m_activeEntries;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsDisposed;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0_UntrackImpl;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0__UntrackInactiveEntries;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ReleaseAllEntries;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate0 __Hotfix0_StartCoroutine;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ReleaseCoroutine;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate0 __Hotfix0_Track;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate0 __Hotfix0_KillAndUntrack;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate0 __Hotfix1_Track;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ReleaseAndUntrack;

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		public interface ICustom : IHotfixable
		{
			// Token: 0x06000443 RID: 1091
			[Token(Token = "0x6000443")]
			bool CheckActive();

			// Token: 0x06000444 RID: 1092
			[Token(Token = "0x6000444")]
			void Release();
		}

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		protected enum EntryType
		{
			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			NONE,
			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			TWEEN,
			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			COROUTINE,
			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			CUSTOM
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		protected class Entry
		{
			// Token: 0x06000445 RID: 1093 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x54FC540", Offset = "0x54FB140", VA = "0x1854FC540")]
			public void Reset()
			{
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x54FC5A0", Offset = "0x54FB1A0", VA = "0x1854FC5A0")]
			public Entry()
			{
			}

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x10")]
			public AutoReleasableGroup.EntryType type;

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			[FieldOffset(Offset = "0x18")]
			public readonly WeakReference targetRef;
		}
	}
}
