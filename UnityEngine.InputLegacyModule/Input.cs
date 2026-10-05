using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public class Input
	{
		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59B82B0", Offset = "0x59B6EB0", VA = "0x1859B82B0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyInt(KeyCode key);

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59B82F0", Offset = "0x59B6EF0", VA = "0x1859B82F0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyString(string name);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59B8330", Offset = "0x59B6F30", VA = "0x1859B8330")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyUpInt(KeyCode key);

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x59B8370", Offset = "0x59B6F70", VA = "0x1859B8370")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyUpString(string name);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59B8230", Offset = "0x59B6E30", VA = "0x1859B8230")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyDownInt(KeyCode key);

		// Token: 0x06000023 RID: 35
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59B8270", Offset = "0x59B6E70", VA = "0x1859B8270")]
		[NativeThrows]
		[MethodImpl(4096)]
		private static extern bool GetKeyDownString(string name);

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x59B8140", Offset = "0x59B6D40", VA = "0x1859B8140")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern float GetAxis(string axisName);

		// Token: 0x06000025 RID: 37
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x59B8100", Offset = "0x59B6D00", VA = "0x1859B8100")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern float GetAxisRaw(string axisName);

		// Token: 0x06000026 RID: 38
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59B81C0", Offset = "0x59B6DC0", VA = "0x1859B81C0")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern bool GetButton(string buttonName);

		// Token: 0x06000027 RID: 39
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x59B8180", Offset = "0x59B6D80", VA = "0x1859B8180")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern bool GetButtonDown(string buttonName);

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x59B8430", Offset = "0x59B7030", VA = "0x1859B8430")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern bool GetMouseButton(int button);

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x59B83B0", Offset = "0x59B6FB0", VA = "0x1859B83B0")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern bool GetMouseButtonDown(int button);

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59B83F0", Offset = "0x59B6FF0", VA = "0x1859B83F0")]
		[NativeThrows]
		[MethodImpl(4096)]
		public static extern bool GetMouseButtonUp(int button);

		// Token: 0x0600002B RID: 43 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x59B84B0", Offset = "0x59B70B0", VA = "0x1859B84B0")]
		[NativeThrows]
		public static Touch GetTouch(int index)
		{
			return default(Touch);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x59B82B0", Offset = "0x59B6EB0", VA = "0x1859B82B0")]
		public static bool GetKey(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x59B82F0", Offset = "0x59B6EF0", VA = "0x1859B82F0")]
		public static bool GetKey(string name)
		{
			return default(bool);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x59B8330", Offset = "0x59B6F30", VA = "0x1859B8330")]
		public static bool GetKeyUp(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x59B8370", Offset = "0x59B6F70", VA = "0x1859B8370")]
		public static bool GetKeyUp(string name)
		{
			return default(bool);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x59B8230", Offset = "0x59B6E30", VA = "0x1859B8230")]
		public static bool GetKeyDown(KeyCode key)
		{
			return default(bool);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59B8270", Offset = "0x59B6E70", VA = "0x1859B8270")]
		public static bool GetKeyDown(string name)
		{
			return default(bool);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000032 RID: 50
		[Token(Token = "0x17000012")]
		[NativeThrows]
		public static extern bool anyKeyDown { [Token(Token = "0x6000032")] [Address(RVA = "0x59B8510", Offset = "0x59B7110", VA = "0x1859B8510")] [MethodImpl(4096)] get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000033 RID: 51
		[Token(Token = "0x17000013")]
		[NativeThrows]
		public static extern string inputString { [Token(Token = "0x6000033")] [Address(RVA = "0x59B8730", Offset = "0x59B7330", VA = "0x1859B8730")] [MethodImpl(4096)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x17000014")]
		[NativeThrows]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x59B87A0", Offset = "0x59B73A0", VA = "0x1859B87A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x17000015")]
		[NativeThrows]
		public static Vector2 mouseScrollDelta
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x59B8850", Offset = "0x59B7450", VA = "0x1859B8850")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000036 RID: 54
		// (set) Token: 0x06000037 RID: 55
		[Token(Token = "0x17000016")]
		public static extern IMECompositionMode imeCompositionMode { [Token(Token = "0x6000036")] [Address(RVA = "0x59B8700", Offset = "0x59B7300", VA = "0x1859B8700")] [MethodImpl(4096)] get; [Token(Token = "0x6000037")] [Address(RVA = "0x59B8AA0", Offset = "0x59B76A0", VA = "0x1859B8AA0")] [MethodImpl(4096)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000038 RID: 56
		[Token(Token = "0x17000017")]
		public static extern string compositionString { [Token(Token = "0x6000038")] [Address(RVA = "0x59B85C0", Offset = "0x59B71C0", VA = "0x1859B85C0")] [MethodImpl(4096)] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000018")]
		public static Vector2 compositionCursorPos
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x59B8580", Offset = "0x59B7180", VA = "0x1859B8580")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x59B8A60", Offset = "0x59B7660", VA = "0x1859B8A60")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003B RID: 59
		[Token(Token = "0x17000019")]
		public static extern bool mousePresent { [Token(Token = "0x600003B")] [Address(RVA = "0x59B87E0", Offset = "0x59B73E0", VA = "0x1859B87E0")] [FreeFunction("GetMousePresent")] [MethodImpl(4096)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003C RID: 60
		[Token(Token = "0x1700001A")]
		public static extern int touchCount { [Token(Token = "0x600003C")] [Address(RVA = "0x59B8890", Offset = "0x59B7490", VA = "0x1859B8890")] [FreeFunction("GetTouchCount")] [MethodImpl(4096)] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003D RID: 61
		[Token(Token = "0x1700001B")]
		public static extern bool touchSupported { [Token(Token = "0x600003D")] [Address(RVA = "0x59B88C0", Offset = "0x59B74C0", VA = "0x1859B88C0")] [FreeFunction("IsTouchSupported")] [MethodImpl(4096)] get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003E RID: 62
		[Token(Token = "0x1700001C")]
		public static extern DeviceOrientation deviceOrientation { [Token(Token = "0x600003E")] [Address(RVA = "0x59B85F0", Offset = "0x59B71F0", VA = "0x1859B85F0")] [FreeFunction("GetOrientation")] [MethodImpl(4096)] get; }

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59B8200", Offset = "0x59B6E00", VA = "0x1859B8200")]
		[FreeFunction("GetGyro")]
		[MethodImpl(4096)]
		private static extern int GetGyroInternal();

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001D")]
		public static Gyroscope gyro
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x59B8620", Offset = "0x59B7220", VA = "0x1859B8620")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001E")]
		public static Touch[] touches
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x59B88F0", Offset = "0x59B74F0", VA = "0x1859B88F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000042 RID: 66
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59B80D0", Offset = "0x59B6CD0", VA = "0x1859B80D0")]
		[MethodImpl(4096)]
		internal static extern bool CheckDisabled();

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x59B8470", Offset = "0x59B7070", VA = "0x1859B8470")]
		[MethodImpl(4096)]
		private static extern void GetTouch_Injected(int index, out Touch ret);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59B8760", Offset = "0x59B7360", VA = "0x1859B8760")]
		[MethodImpl(4096)]
		private static extern void get_mousePosition_Injected(out Vector3 ret);

		// Token: 0x06000045 RID: 69
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59B8810", Offset = "0x59B7410", VA = "0x1859B8810")]
		[MethodImpl(4096)]
		private static extern void get_mouseScrollDelta_Injected(out Vector2 ret);

		// Token: 0x06000046 RID: 70
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59B8540", Offset = "0x59B7140", VA = "0x1859B8540")]
		[MethodImpl(4096)]
		private static extern void get_compositionCursorPos_Injected(out Vector2 ret);

		// Token: 0x06000047 RID: 71
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59B8A20", Offset = "0x59B7620", VA = "0x1859B8A20")]
		[MethodImpl(4096)]
		private static extern void set_compositionCursorPos_Injected(ref Vector2 value);

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static Gyroscope s_MainGyro;
	}
}
