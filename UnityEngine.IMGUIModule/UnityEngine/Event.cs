using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/IMGUI/Event.bindings.h")]
	[StructLayout(0)]
	public sealed class Event
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		[NativeProperty("type", false, TargetType.Field)]
		public extern EventType rawType { [Token(Token = "0x6000003")] [Address(RVA = "0x598CAF0", Offset = "0x598B6F0", VA = "0x18598CAF0")] [MethodImpl(4096)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		[NativeProperty("mousePosition", false, TargetType.Field)]
		public Vector2 mousePosition
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x598CA20", Offset = "0x598B620", VA = "0x18598CA20")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x598CEA0", Offset = "0x598BAA0", VA = "0x18598CEA0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		[NativeProperty("delta", false, TargetType.Field)]
		public Vector2 delta
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x598C7A0", Offset = "0x598B3A0", VA = "0x18598C7A0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x598CD50", Offset = "0x598B950", VA = "0x18598CD50")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8
		[Token(Token = "0x17000004")]
		[NativeProperty("pointerType", false, TargetType.Field)]
		public extern PointerType pointerType { [Token(Token = "0x6000008")] [Address(RVA = "0x598CA70", Offset = "0x598B670", VA = "0x18598CA70")] [MethodImpl(4096)] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9
		[Token(Token = "0x17000005")]
		[NativeProperty("button", false, TargetType.Field)]
		public extern int button { [Token(Token = "0x6000009")] [Address(RVA = "0x598C590", Offset = "0x598B190", VA = "0x18598C590")] [MethodImpl(4096)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10
		// (set) Token: 0x0600000B RID: 11
		[Token(Token = "0x17000006")]
		[NativeProperty("modifiers", false, TargetType.Field)]
		public extern EventModifiers modifiers { [Token(Token = "0x600000A")] [Address(RVA = "0x598C990", Offset = "0x598B590", VA = "0x18598C990")] [MethodImpl(4096)] get; [Token(Token = "0x600000B")] [Address(RVA = "0x598CE10", Offset = "0x598BA10", VA = "0x18598CE10")] [MethodImpl(4096)] set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12
		[Token(Token = "0x17000007")]
		[NativeProperty("pressure", false, TargetType.Field)]
		public extern float pressure { [Token(Token = "0x600000C")] [Address(RVA = "0x598CAB0", Offset = "0x598B6B0", VA = "0x18598CAB0")] [MethodImpl(4096)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13
		[Token(Token = "0x17000008")]
		[NativeProperty("clickCount", false, TargetType.Field)]
		public extern int clickCount { [Token(Token = "0x600000D")] [Address(RVA = "0x598C610", Offset = "0x598B210", VA = "0x18598C610")] [MethodImpl(4096)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14
		// (set) Token: 0x0600000F RID: 15
		[Token(Token = "0x17000009")]
		[NativeProperty("character", false, TargetType.Field)]
		public extern char character { [Token(Token = "0x600000E")] [Address(RVA = "0x598C5D0", Offset = "0x598B1D0", VA = "0x18598C5D0")] [MethodImpl(4096)] get; [Token(Token = "0x600000F")] [Address(RVA = "0x598CBB0", Offset = "0x598B7B0", VA = "0x18598CBB0")] [MethodImpl(4096)] set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		[Token(Token = "0x1700000A")]
		[NativeProperty("keycode", false, TargetType.Field)]
		public extern KeyCode keyCode { [Token(Token = "0x6000010")] [Address(RVA = "0x598C950", Offset = "0x598B550", VA = "0x18598C950")] [MethodImpl(4096)] get; [Token(Token = "0x6000011")] [Address(RVA = "0x598CDD0", Offset = "0x598B9D0", VA = "0x18598CDD0")] [MethodImpl(4096)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		[Token(Token = "0x1700000B")]
		[NativeProperty("displayIndex", false, TargetType.Field)]
		public extern int displayIndex { [Token(Token = "0x6000012")] [Address(RVA = "0x598C7F0", Offset = "0x598B3F0", VA = "0x18598C7F0")] [MethodImpl(4096)] get; [Token(Token = "0x6000013")] [Address(RVA = "0x598CD90", Offset = "0x598B990", VA = "0x18598CD90")] [MethodImpl(4096)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		[Token(Token = "0x1700000C")]
		public extern EventType type { [Token(Token = "0x6000014")] [Address(RVA = "0x598CB70", Offset = "0x598B770", VA = "0x18598CB70")] [FreeFunction("GUIEvent::GetType", HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000015")] [Address(RVA = "0x598CEE0", Offset = "0x598BAE0", VA = "0x18598CEE0")] [FreeFunction("GUIEvent::SetType", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000016 RID: 22
		// (set) Token: 0x06000017 RID: 23
		[Token(Token = "0x1700000D")]
		public extern string commandName { [Token(Token = "0x6000016")] [Address(RVA = "0x598C650", Offset = "0x598B250", VA = "0x18598C650")] [FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000017")] [Address(RVA = "0x598CC00", Offset = "0x598B800", VA = "0x18598CC00")] [FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x598A550", Offset = "0x5989150", VA = "0x18598A550")]
		[NativeMethod("Use")]
		[MethodImpl(4096)]
		private extern void Internal_Use();

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x598A320", Offset = "0x5988F20", VA = "0x18598A320")]
		[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(int displayIndex);

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x598A360", Offset = "0x5988F60", VA = "0x18598A360")]
		[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x598A2E0", Offset = "0x5988EE0", VA = "0x18598A2E0")]
		[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern EventType GetTypeForControl(int controlID);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5989D90", Offset = "0x5988990", VA = "0x185989D90")]
		[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		[MethodImpl(4096)]
		internal extern void CopyFromPtr(IntPtr ptr);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x598B810", Offset = "0x598A410", VA = "0x18598B810")]
		[MethodImpl(4096)]
		public static extern bool PopEvent([NotNull("ArgumentNullException")] Event outEvent);

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x598A510", Offset = "0x5989110", VA = "0x18598A510")]
		[MethodImpl(4096)]
		private static extern void Internal_SetNativeEvent(IntPtr ptr);

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x598A3A0", Offset = "0x5988FA0", VA = "0x18598A3A0")]
		[RequiredByNativeCode]
		internal static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
		}

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x598A170", Offset = "0x5988D70", VA = "0x18598A170")]
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.UIElementsModule"
		})]
		[MethodImpl(4096)]
		internal static extern int GetDoubleClickTime();

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x598C4C0", Offset = "0x598B0C0", VA = "0x18598C4C0")]
		public Event()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x598C500", Offset = "0x598B100", VA = "0x18598C500")]
		public Event(int displayIndex)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x598A090", Offset = "0x5988C90", VA = "0x18598A090", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5989DE0", Offset = "0x59889E0", VA = "0x185989DE0")]
		internal void CopyFrom(Event e)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x1700000E")]
		public bool shift
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x598CB30", Offset = "0x598B730", VA = "0x18598CB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x1700000F")]
		public bool control
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x598C6D0", Offset = "0x598B2D0", VA = "0x18598C6D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000010")]
		public bool alt
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x598C550", Offset = "0x598B150", VA = "0x18598C550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x17000011")]
		public bool command
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x598C690", Offset = "0x598B290", VA = "0x18598C690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public static Event current
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x598C710", Offset = "0x598B310", VA = "0x18598C710")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x598CC50", Offset = "0x598B850", VA = "0x18598CC50")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x17000013")]
		public bool isKey
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x598C8A0", Offset = "0x598B4A0", VA = "0x18598C8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x17000014")]
		public bool isMouse
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x598C8F0", Offset = "0x598B4F0", VA = "0x18598C8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000015")]
		internal bool isDirectManipulationDevice
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x598C830", Offset = "0x598B430", VA = "0x18598C830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x598A590", Offset = "0x5989190", VA = "0x18598A590")]
		public static Event KeyboardEvent(string key)
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x598A1A0", Offset = "0x5988DA0", VA = "0x18598A1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5989E50", Offset = "0x5988A50", VA = "0x185989E50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x598B850", Offset = "0x598A450", VA = "0x18598B850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x598C300", Offset = "0x598AF00", VA = "0x18598C300")]
		public void Use()
		{
		}

		// Token: 0x06000033 RID: 51
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x598C9D0", Offset = "0x598B5D0", VA = "0x18598C9D0")]
		[MethodImpl(4096)]
		private extern void get_mousePosition_Injected(out Vector2 ret);

		// Token: 0x06000034 RID: 52
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x598CE50", Offset = "0x598BA50", VA = "0x18598CE50")]
		[MethodImpl(4096)]
		private extern void set_mousePosition_Injected(ref Vector2 value);

		// Token: 0x06000035 RID: 53
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x598C750", Offset = "0x598B350", VA = "0x18598C750")]
		[MethodImpl(4096)]
		private extern void get_delta_Injected(out Vector2 ret);

		// Token: 0x06000036 RID: 54
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x598CD00", Offset = "0x598B900", VA = "0x18598CD00")]
		[MethodImpl(4096)]
		private extern void set_delta_Injected(ref Vector2 value);

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Event s_Current;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Event s_MasterEvent;
	}
}
