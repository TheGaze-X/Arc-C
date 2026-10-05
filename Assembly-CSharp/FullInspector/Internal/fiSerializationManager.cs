using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CA5 RID: 31909
	[Token(Token = "0x2007CA5")]
	public static class fiSerializationManager
	{
		// Token: 0x0602C91B RID: 182555 RVA: 0x000E0DF0 File Offset: 0x000DEFF0
		[Token(Token = "0x602C91B")]
		private static bool SupportsMultithreading<TSerializer>() where TSerializer : BaseSerializer
		{
			return default(bool);
		}

		// Token: 0x0602C91C RID: 182556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C91C")]
		public static void OnUnityObjectAwake<TSerializer>(ISerializedObject obj) where TSerializer : BaseSerializer
		{
		}

		// Token: 0x0602C91D RID: 182557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C91D")]
		public static void OnUnityObjectDeserialize<TSerializer>(ISerializedObject obj) where TSerializer : BaseSerializer
		{
		}

		// Token: 0x0602C91E RID: 182558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C91E")]
		public static void OnUnityObjectSerialize<TSerializer>(ISerializedObject obj) where TSerializer : BaseSerializer
		{
		}

		// Token: 0x0602C91F RID: 182559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C91F")]
		[Address(RVA = "0x2871460", Offset = "0x2870060", VA = "0x182871460")]
		private static void OnEditorUpdate()
		{
		}

		// Token: 0x0602C920 RID: 182560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C920")]
		[Address(RVA = "0x2870AF0", Offset = "0x286F6F0", VA = "0x182870AF0")]
		private static void DoDeserialize(ISerializedObject obj)
		{
		}

		// Token: 0x0602C921 RID: 182561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C921")]
		[Address(RVA = "0x2870B40", Offset = "0x286F740", VA = "0x182870B40")]
		private static void DoSerialize(ISerializedObject obj)
		{
		}

		// Token: 0x0602C922 RID: 182562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C922")]
		[Address(RVA = "0x2871040", Offset = "0x286FC40", VA = "0x182871040")]
		private static void HandleReset(ISerializedObject obj)
		{
		}

		// Token: 0x0602C923 RID: 182563 RVA: 0x000E0E08 File Offset: 0x000DF008
		[Token(Token = "0x602C923")]
		private static bool IsNullOrEmpty<T>(IList<T> list)
		{
			return default(bool);
		}

		// Token: 0x0602C924 RID: 182564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C924")]
		[Address(RVA = "0x2871DB0", Offset = "0x28709B0", VA = "0x182871DB0")]
		public static void SerializeObject(Type logContext, object obj)
		{
		}

		// Token: 0x0602C925 RID: 182565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C925")]
		[Address(RVA = "0x2871EF0", Offset = "0x2870AF0", VA = "0x182871EF0")]
		private static void Serialize(Type logContext, object obj)
		{
		}

		// Token: 0x040403C1 RID: 263105
		[Token(Token = "0x40403C1")]
		[FieldOffset(Offset = "0x0")]
		private static fiSerializationManager.DeferredSerialization s_inspectedObjectSerialization;

		// Token: 0x040403C2 RID: 263106
		[Token(Token = "0x40403C2")]
		[FieldOffset(Offset = "0x8")]
		[NonSerialized]
		public static bool DisableAutomaticSerialization;

		// Token: 0x040403C3 RID: 263107
		[Token(Token = "0x40403C3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<ISerializedObject> s_pendingDeserializations;

		// Token: 0x040403C4 RID: 263108
		[Token(Token = "0x40403C4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<ISerializedObject> s_pendingSerializations;

		// Token: 0x040403C5 RID: 263109
		[Token(Token = "0x40403C5")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<ISerializedObject, fiSerializedObjectSnapshot> s_snapshots;

		// Token: 0x040403C6 RID: 263110
		[Token(Token = "0x40403C6")]
		[FieldOffset(Offset = "0x28")]
		public static HashSet<UnityEngine.Object> DirtyForceSerialize;

		// Token: 0x040403C7 RID: 263111
		[Token(Token = "0x40403C7")]
		[FieldOffset(Offset = "0x30")]
		private static ISerializedObject[] s_cachedSelection;

		// Token: 0x040403C8 RID: 263112
		[Token(Token = "0x40403C8")]
		[FieldOffset(Offset = "0x38")]
		private static HashSet<ISerializedObject> s_seen;

		// Token: 0x02007CA6 RID: 31910
		[Token(Token = "0x2007CA6")]
		private class DeferredSerialization
		{
			// Token: 0x0602C926 RID: 182566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C926")]
			[Address(RVA = "0x2855450", Offset = "0x2854050", VA = "0x182855450")]
			public void RequestSerialization(UnityEngine.Object tracking)
			{
			}

			// Token: 0x0602C927 RID: 182567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C927")]
			[Address(RVA = "0x2855630", Offset = "0x2854230", VA = "0x182855630")]
			private void Update()
			{
			}

			// Token: 0x0602C928 RID: 182568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C928")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DeferredSerialization()
			{
			}

			// Token: 0x040403C9 RID: 263113
			[Token(Token = "0x40403C9")]
			[FieldOffset(Offset = "0x0")]
			private static TimeSpan DELAY;

			// Token: 0x040403CA RID: 263114
			[Token(Token = "0x40403CA")]
			[FieldOffset(Offset = "0x10")]
			private UnityEngine.Object _tracking;

			// Token: 0x040403CB RID: 263115
			[Token(Token = "0x40403CB")]
			[FieldOffset(Offset = "0x18")]
			private DateTime _startTime;
		}
	}
}
