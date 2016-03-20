﻿Imports Beehind.Common_Definitions
Imports Beehind.Common_Functions
Imports Beehind.Processes
Imports System.IO



Public Class ResourceHandler

    Public Shared Sub ExtractResources()
        If Beehind.Betashit.IsRelease = True Then


            CreateDirectory(appdata, "\beehind", True)
            IO.File.WriteAllBytes(tempdir + "\beehind-resources.rar", My.Resources.beehind_resources)
            IO.File.WriteAllBytes(tempdir + "\unrar.exe", My.Resources.unrar)
            unrar(tempdir + "\beehind-resources.rar", tempdir)
            Delay(3)
            Delete(False, tempdir + "\beehind-resources.rar")
            Delete(False, tempdir + "\unrar.exe")

            If DeterminateCurrentDate().ToString.Contains("25/12") Then
                'è natale, mettere i loghi fighi
                Dim ChristmasLogoInBytes = ConvertHexStringToByteArray(("89 50 4E 47 0D 0A 1A 0A 00 00 00 0D 49 48 44 52 00 00 00 C0 00 00 01 40 08 03 00 00 00 DD C5 83 59 00 00 02 B2 50 4C 54 45 00 00 00 FF FF FF FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 01 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 0C 0C 0B FF FF FF FF FF FF 00 00 00 FF FF FF F4 27 12 ED EC E8 F7 49 0E EC EB E7 07 07 07 C9 C9 C9 FF 29 13 CB 1E 0A 14 14 14 B9 B9 B9 F4 24 12 93 93 93 EC EC EC F7 4B 0E F7 4A 0E EC EB E6 EE ED E9 48 48 48 03 02 02 0A 0A 0A C7 1D 0A EF EE EA 04 04 04 46 46 46 F7 27 12 F6 27 12 CB CB CB 0D 0D 0D F5 F4 F1 C9 1D 0A 1D 1D 1C C7 C7 C7 F1 F0 ED FE FE FD FA F8 F4 F0 EF EC FC FB F7 F8 F8 F6 20 20 20 ED EC E7 F3 F2 EF 1A 1A 1A FB 28 12 F4 F3 F0 24 24 24 FB FA F5 D0 1F 0C D7 D7 D7 2A 2A 2A 27 27 27 DA DA DA 35 35 35 16 16 16 F2 F1 EE CF CF CE FD FC F8 DD DD DD 2E 2E 2E D6 21 0D 30 30 30 43 42 42 F6 36 10 FD FD FC 2C 2C 2C F7 47 0E F9 F7 F3 D4 D4 D3 FA FA F9 32 32 32 CD CD CC C2 C2 C1 FB FB FA 59 59 58 F5 2E 11 EC 25 10 F7 43 0F 0F 0F 0F FD FC FC 3B 3B 3A F5 2B 11 11 11 11 EF 25 10 07 01 00 DF DF DE 51 51 50 4B 4B 4A FF FE FA E5 23 0F F5 F5 F3 E2 E2 E1 D2 D2 D2 86 86 85 7B 7A 79 4E 4E 4E 37 37 37 FD 28 12 F2 26 11 F7 40 0E BF BE BC 6F 6E 6D F6 3A 10 E1 23 0F F7 45 0E 19 04 01 F9 F9 F8 E9 E8 E4 89 89 89 54 0D 06 E4 E4 E4 A0 A0 9E 9A 9A 98 5E 5E 5E 56 55 54 13 13 13 F7 3D 0F E8 24 0F F7 F6 F3 F7 F6 F1 D6 D6 D4 D0 D0 D0 B1 B0 AF 78 78 76 74 74 72 F4 29 11 F1 26 10 DB 22 0E AC AC AA 83 83 82 6B 6B 6A DE 22 0E CD 1F 0C D3 20 0B 14 03 01 E6 E5 E1 A4 A4 A2 63 63 62 F6 33 10 F6 30 10 C5 C5 C2 B7 B7 B4 B4 B4 B3 A7 A7 A6 7F 7F 7E 67 67 66 3E 3E 3E 74 12 08 D8 21 0D 6B 11 07 36 08 04 2B 07 03 23 05 02 C0 1E 0E B9 1E 0D 64 0F 07 5D 0E 07 0D 02 01 9D 9D 9B 8F 8F 8D 8C 8C 8C AB 1B 0C 46 0B 05 1E 05 02 DD DC D8 F9 27 12 97 18 0B 7C 14 09 E8 E8 E8 96 96 95 91 17 0A D9 D9 D7 4C 0C 05 B3 1D 0D 9F 19 0B 8A 16 0A 83 15 09 9C 19 0B 3F 0A 04 FF 28 12 A2 19 0C 18 ED BE 5A 00 00 00 31 74 52 4E 53 00 E3 E1 14 F1 FD 06 2F ED F5 8B 82 DC CA 7B 19 03 E8 E3 C4 24 F9 B9 53 3F 36 1F 0A D5 29 0E D1 AC 9C 94 74 A5 6D 44 B3 5E BE 65 58 4E 49 F4 EF D1 79 2D D9 E5 00 00 18 89 49 44 41 54 78 DA D4 D8 3B 4F DB 50 14 00 60 4B 84 B6 84 94 16 68 93 16 E8 FB 45 5F C3 D1 55 86 1B C9 92 3D 20 0F F6 90 3F E0 C1 3F C0 52 24 AF 31 43 E4 2C 19 93 48 79 0C D9 60 0C 19 F2 18 C8 08 24 84 C0 50 AA 82 84 80 42 E9 FF E8 B1 03 C6 49 4A A7 B6 76 3E 44 86 64 39 27 E7 71 AF C3 FC 5D 73 1F 5E 85 9E 32 23 EB ED 8B 00 00 BC FF C4 8C A8 29 1F 58 26 5E DC 66 46 CF FD D0 73 B0 F9 FC 73 CC A8 F1 03 2A B6 5A DD A3 F3 83 AD 16 CC 4C 3D 61 46 C9 D8 8B 71 80 F6 59 4D 37 A8 69 F5 4B 77 2F E0 7F C0 8C 8C C7 B3 00 7B 67 3A A5 B2 2C 12 42 C4 34 95 85 DD BD 99 C9 51 69 A4 D0 1D 28 EE 46 A9 4C 2E B1 2C 91 28 ED 94 8A 81 C9 91 A8 42 68 1A DA 1D 4A AF A3 4F 24 08 9B C1 14 22 1B DB 81 37 63 8C D7 7D 98 80 FD 0A 95 48 4F A2 B9 B2 AC 69 D9 58 D9 4A A1 BA 95 7C 36 E5 F1 46 FA 38 01 25 83 92 2B 59 8E E3 78 9E E3 0A EB 84 25 22 A5 3B 2D 98 9E BA C7 78 D7 A2 0F 5A AB 69 72 85 CD 71 61 0B C7 E7 CA 2C BE 41 53 1B 0D 58 F0 6E 23 E1 F7 DF E8 50 62 63 E3 61 3E 6C E1 B1 08 E6 2C A4 A9 B0 0F 30 BB C8 78 D2 27 1F C0 21 95 1C 09 24 0A 98 80 9D 42 2E C1 B2 12 25 E7 5F 61 3C F8 96 F1 9E 47 D3 00 2D 5D 26 4E 2B 5C F8 1A 17 5E 69 12 56 A4 95 AD 06 8C FB 3D D7 47 B7 03 00 DB 0A 25 4E 6C 8C E3 4D 76 23 85 B3 B1 78 26 7D D1 29 ED C1 AC C7 2E 79 73 77 01 E0 88 92 7E B1 E5 1E CD 4E 81 D3 B2 B9 E6 85 58 EB 26 9F 79 2A 83 B1 20 00 B4 53 94 FC 5E 7C D9 31 0C 5C 38 26 D1 8B D3 E4 4C 88 F1 8C F9 E7 80 0E 28 B9 01 1B 73 0E 03 CF AF E3 28 7C 4F FA 3E 33 5E E1 07 74 28 4B 64 C8 F0 34 23 2E 6B 9E 6B 87 30 F3 98 F1 86 57 4B 00 B0 2F C9 64 98 73 9F DA B8 42 82 25 69 A3 0D C1 79 C6 03 EE 2F 4E 00 40 51 A1 64 88 F3 48 76 E2 62 2C 21 74 A7 31 3E C5 78 40 C8 8C 7F 09 07 E0 46 71 DC 42 3C E2 78 67 09 08 3D 4D 3E F4 C0 20 DF 0F 02 EA A6 45 32 68 E0 52 A7 15 0A 9A 9D 41 0E 13 90 E5 63 98 76 7F 99 86 7C 66 03 A9 69 72 F3 08 C7 72 B9 D8 7A 33 5E 2E 27 B2 DC D5 22 B2 9A 48 68 40 D0 ED 23 F9 C1 02 A0 73 4A C8 5A 46 BA 21 07 F6 92 63 9D F2 BD 31 38 02 98 64 5C 35 FF 1E D0 56 5A 16 F3 4A 5D 4D 11 91 FC 01 4B B2 D7 07 5A 38 46 32 A2 D8 86 19 77 9F 34 DF 00 DA 25 E9 4C 35 12 45 AA F1 C7 0C 72 66 FC CE 1A D0 93 22 BC 73 73 97 DE 5B B0 06 80 1A F5 68 C4 14 55 52 44 12 25 49 BA 61 9B F2 CE 03 59 4B 60 06 3F 93 E0 67 DC 33 09 68 83 66 EA 42 C4 82 65 50 2A F9 6A B5 A2 D6 55 5D 1A 88 BF 89 F1 3B 71 2B E6 26 2A C1 43 F7 AE 14 8F CD 0D 74 AC 8B 6A 2F 7E C1 16 C5 3F 75 B0 0C 78 A3 EB C3 F3 71 2C C1 E6 36 2C B8 31 06 76 01 F6 F5 35 05 FB 27 2A 08 35 45 AD 56 F3 29 B4 69 D6 42 15 89 53 D9 5A A1 03 25 B0 0E E4 24 BC 64 DC 31 FF 0C E0 6B 45 8C 0A 11 21 52 AF E4 F5 35 F2 4D 96 45 51 94 F3 02 96 23 25 0D 5C 48 39 DE E2 BC D4 E1 07 22 ED C2 1D 97 8E B3 0F 4B B0 74 22 2B 42 34 A2 AE 62 24 32 A5 14 E3 11 09 51 30 A5 FA D0 33 41 41 2B 68 1A 86 CD DB 09 2C 97 F1 03 59 2F C1 EC 53 C6 05 73 01 80 5D 51 11 04 65 95 98 C1 CB F9 F3 AD E3 D2 91 2E 57 85 48 34 82 33 3C A0 9C 48 24 E2 F1 E6 BA 3D 0B 9C 16 B7 7E 6D C9 6F BB B3 89 70 02 5A 6A 5D 50 53 18 BD BE 73 7A 56 6A 03 DA 53 75 73 A5 A6 86 97 29 6B FE A3 15 CE 3E CC 30 01 44 BF 24 7D 2E 3C 1A 60 01 1A 9D 94 62 50 B1 73 D8 6D 27 E1 52 C9 C0 99 AE E9 E2 9A 61 18 BF 3D 8D 73 D8 46 8E 3B 1D 92 E8 06 04 FF 7F 13 61 01 BE D3 35 6A 1C 1C 27 C1 E1 44 C7 09 56 AA AA 52 AB 45 56 A5 C1 F0 CB 71 E7 32 E2 B5 26 4B 2E 9B 68 91 F9 CF F0 0C D8 CD 50 AA 1C 43 9F 1F D2 A6 60 1D 09 51 7C 49 89 03 F1 E3 D3 7D DF 32 E5 7B 53 20 D1 A3 A5 F7 FF F6 46 F1 74 EC 16 D3 EF 35 B4 74 BA D3 2D 42 CF C3 71 B0 6C D0 94 12 B9 BA 57 18 03 DD 13 D3 EC 15 D4 3F C7 A2 FC 8B 56 73 F1 69 EA 8A E3 B8 89 80 30 04 44 1E A2 A0 20 20 4C D4 25 E7 F6 EE 74 D5 6D 61 F7 0A 5C 2C D9 85 B5 B7 ED 5A A9 65 9A D1 35 E9 46 B3 AE 1B 45 1D 38 18 74 6C B2 81 20 2F 09 1B E1 E1 00 C1 17 3A 51 34 28 18 DD 74 06 91 99 8D EC 91 65 FF C7 7E E7 B6 14 68 8B C6 94 7E 34 18 84 C0 F7 77 CF EF FC 9E F7 17 14 D8 EE 6C 7B 58 7C DA BA A5 36 6C 0D CD 99 91 FD E5 92 1F 14 F1 52 42 84 EB 0A 40 6B 5F DD EA 4C CC 97 96 1F C0 F5 E3 6E F9 5E 5E 24 CB AB 09 4A 58 13 38 36 A4 83 B6 E8 94 B4 04 F7 39 A7 A2 BB 33 5D 48 24 3A 35 03 BA 92 4C 24 F2 B8 18 9E 67 F5 65 E2 40 25 D5 CB AE 40 19 E4 30 6F 20 14 8D 83 05 72 79 57 60 43 69 56 F0 B5 1B BF FE 50 14 94 1C 2E 46 8B DD 3B E3 D0 BD 2B 88 10 9C E2 4C A3 09 F1 11 D1 F0 E9 BD 91 02 89 FC 2B E2 43 9E 99 E0 B8 CB FB BD CF A0 8C 1C C1 FD 87 A1 81 5C 66 AE 8B 6E A1 0C 86 F9 A1 CF 51 4A E2 9A 90 D4 60 E4 22 34 7E 77 C8 C2 29 25 6E 85 EE A6 06 06 EC 05 A3 79 C4 81 3C 42 90 77 2D E4 EE 0C 7A 61 E8 DB F8 00 6D 5F 13 38 B6 6C 3C F8 81 15 0F 98 26 AA 50 64 6C 3A 72 11 91 96 10 B2 FC 62 93 D0 2A 91 98 21 15 9B 9B 3C AB E9 8F 9F 65 01 C9 66 01 3B 82 C4 CD 19 91 61 F9 3F A9 B5 98 16 F0 99 57 92 90 93 F5 9E EB A2 D8 50 24 AE 08 C4 F2 F4 98 5C E2 15 43 B3 57 32 01 BA B3 B9 80 DD 82 4D E9 49 AF 84 05 23 E9 A0 9A 63 31 3D E0 A8 75 39 4F 9A D7 B6 2B D2 19 47 0B 8E ED 05 FA E6 BC 93 F0 B8 57 1C 72 97 75 92 26 59 C9 C3 E8 40 1C 41 42 58 6E C3 CD F3 67 26 4F 72 9C 46 43 D3 D8 70 33 1F 01 99 DE 15 70 54 32 02 FE 91 49 FA 88 01 63 CE 18 E4 99 09 DA 7C 9B 90 0D A1 48 F6 20 20 47 10 8E AA 6C 94 C1 A4 16 54 8C 8D AA 67 F0 C0 8F FB 10 F2 39 CE C9 20 23 BA 9A 9F 65 92 D6 42 92 C6 2E 5F 6A F2 35 26 ED F5 19 4D 49 6B D0 98 F7 30 28 00 2F B7 AC 4B 3A F2 09 C5 D2 2C 4B 63 0D A5 D4 31 FA B3 07 11 CC 42 56 6A 90 DB FB E6 0A A0 9C 06 F2 20 8E FA 9A 11 95 2D AC FE 3C 6A 0A B1 A6 43 31 21 10 CF 42 42 56 D5 82 88 C3 E7 8D 2C 0D DE 63 A4 28 0B C7 E1 EF BF 43 A1 3B BC 7F 45 48 A6 98 89 E7 24 05 CE 11 45 9E D9 F7 90 EB C4 C7 3E 0D 38 01 81 C8 3C 8B A2 B3 12 76 A4 C7 67 86 AF E6 49 6C 0A 7E FB 86 95 C1 18 73 95 14 38 11 E7 F8 FA F7 8F F2 53 F6 84 78 1A 1A E4 DA 72 8C 40 1E 76 27 62 2F F9 A4 9F F1 61 00 69 CE 1A 5B A1 A3 88 7B A5 F6 87 AA 5C B4 31 3C 6A D5 CA 88 ED 39 45 EF 59 34 F5 3A 96 18 A0 C1 34 E6 1D DC 44 45 50 CC 1E 1F 33 AE D9 B1 46 B9 F3 0A F8 88 A3 6F 9C BB 7E BA ED AD 6C 9F 99 E0 B4 AB BF 47 07 3E D3 F3 57 CB 87 F7 A1 E4 DD 1B 56 67 76 F5 52 EE 47 CD 03 F5 4A 70 1F D0 6F E7 18 2D 78 93 4E E0 3F E8 89 4B DD E6 99 C5 E0 00 E6 AA 2F 8B FA FB E4 CB C5 4B CE 8D 9F 3E 0E 13 76 9F F2 B3 4F 9D 6B 82 AE 00 B6 E0 1F 75 3A 54 2A A3 E0 78 AD 27 37 6C 67 D6 D6 6D 89 5B 12 A2 FC 7A FC BB 92 3F BC A9 B3 62 AC D2 28 29 C0 AE 57 B1 5A 8C 31 CD A9 F5 D7 D0 F6 25 6E B4 36 89 94 72 23 8D D5 25 79 3E F4 1F ED ED 3D 9E ED A5 1E 56 06 00 6C 5F C7 49 4F 70 1F 1C A8 E8 AC 80 69 C2 00 3F 58 27 45 D1 F1 99 49 28 C2 9F B1 D1 9E B8 A2 B3 94 00 57 98 61 F4 4A 8A A0 B4 77 68 EA 55 F0 1F BC AE 2E 38 6B 49 BE 88 13 63 A8 53 7F A1 87 FE EB 6D A0 D3 5B FB AB 6D A7 7A 4F F5 96 1D 95 BC 01 FA 67 48 71 78 46 C9 D0 22 98 33 E9 07 0F E4 23 42 8A 1F BE 94 86 4A BB CB 9B 3B 89 05 9D 1A 6A 01 65 87 56 4B 33 CA C1 9C 98 B5 CB 16 7D 77 64 92 31 F1 F9 7B B4 62 27 DA 16 D5 93 4D 0D D1 0E 0B E3 B2 A3 E7 44 F3 88 FB C3 C2 09 11 07 D2 D1 2E 30 AD 33 D0 CD 87 11 90 E4 C7 0E 61 6B 4C 1C CA CD 7D 64 C0 5A 5A 6F A1 9C F0 3A 85 18 55 85 F3 39 49 8B EF FF C4 43 3B D9 54 2C 0E 19 41 FF 0A 5B 56 22 FD E3 B6 DE D3 F0 D4 4F 80 70 50 EE 44 66 7E 4A F4 1F FA 4C A0 97 A2 A0 2A 10 B0 D1 9F 0A 63 ED EE D4 F5 E8 A2 09 33 3C 45 B0 81 15 46 06 13 3F 65 0D 17 D1 4E F7 35 8E DD 88 D0 7F B2 BE 3C 92 82 FB E4 5E 4B B2 6C 02 6C 99 4E 9D 1E 3F 71 0E A4 83 F6 45 E4 32 B3 38 91 39 3C 21 D0 CB D1 DF 28 22 2D C7 26 FF C2 68 4A 69 39 CF E8 28 11 9D CA 02 E9 18 D3 80 11 7F 8A D2 5D DE 19 15 9B 16 0C 9B FA 62 33 E9 C4 A6 BC 17 C6 47 CB CA CA C6 CB AE BB B4 2F 29 31 0A E4 8D 32 59 C1 5F B3 08 90 4E 98 C0 71 16 C0 58 0B 1F A8 21 04 A4 F9 65 40 E4 17 B7 04 1A DB 28 91 0E CC F5 5B 28 0D 07 3F 5B FF F5 BB 0B C5 57 6C 04 94 AB 35 BF C9 9C 9D D8 58 5F 53 13 D1 06 78 6C 99 9A C8 FC 91 00 AA 5D 14 4F E5 FD E9 1A 6C B4 08 1C ED 86 A1 F5 2A 86 C6 D6 72 29 7C 25 3D C4 9F 38 14 B6 9F A2 D4 0A 15 CF EB 74 FD 4A 4A 81 19 8E B7 F3 18 1C 54 71 3B C7 35 CC D9 15 4C 16 95 C5 12 E8 03 44 C6 C6 CC A3 53 A3 A3 53 53 E6 A9 BE C5 87 2D 8E 1F 8F 4D 99 F7 5E 1E 6D 6D 1D 2D 29 29 FC 73 E6 9F E9 AE 7B 35 48 24 FF 22 D6 D3 6E B0 AA 83 B2 B3 70 91 E7 49 E9 18 E1 CF 26 30 05 1D 19 1A 1E FE 46 07 8E DF C9 59 28 1E 1E 0B A3 85 4B 8C 79 EB 81 D0 CD 0B B1 0A A1 2B 66 19 49 C1 4B 17 05 B0 EC F8 6A 04 A4 CF C1 23 2F 9E AB 2E 9C F9 63 BA EB EE 6C FB 95 2B B3 F7 EE CD B6 B7 5F 79 58 83 DC 7C 3B 68 E4 DD FE A3 C5 BC 92 1C 37 AB E5 14 A4 FD 88 F1 C7 80 54 44 38 A3 26 9A 75 A4 16 22 BF 40 4B 73 26 CD 49 69 44 E2 E2 F7 4C CB E4 64 A8 5B 08 BA 0B F7 96 94 94 98 47 FB AA C1 8D C8 73 97 9B 7F BB F3 E0 31 3C EA 95 D8 D7 F3 93 C2 A4 72 EB 67 58 57 C4 AE C7 AC BA 3B DF 4F 03 A2 76 22 E0 91 09 0C 20 91 48 C3 D0 04 15 DF DC 93 BF 70 05 D6 C6 90 57 0D 1A 25 C7 4A F6 C2 92 63 EA 12 6C 0A 46 46 40 BC 5C 06 48 2E FF DD 35 8B 56 26 BF B4 AE E1 1D 83 81 5B 72 7B 55 36 CA 89 0D 8E 82 A9 F2 CB 85 80 2D 49 90 E1 DF E9 27 4F 46 A1 A4 FA B1 18 A0 59 98 4F A0 30 57 CD BB 39 14 72 80 19 1C 5C 32 02 CB 62 39 A1 B8 B8 11 B4 DF 9F F9 EF 97 BB ED 68 45 A4 47 6A BB 9B DF 51 98 0C 2C E3 96 CF 70 1A 8B 3B 61 1A 21 21 0F 43 F7 BD C5 BF A9 1C 42 B5 0E AD 51 30 0C D0 F5 70 89 C5 4A E5 C9 21 31 BA 2D 5E 81 9C F6 E9 9F 47 61 4D E0 42 D2 5A F2 C7 83 7F 1F D6 E4 20 DF E4 E4 48 0F D5 35 BC FE 25 2F 08 56 23 87 9D 8E 8F 31 43 73 F5 95 D4 22 1A 8C 1D 67 FC CC 64 62 91 50 4B 51 EC 67 E5 4F D4 BC 42 F4 1F 8E BF FA 3E 42 D1 51 6B B6 ED 08 DF B4 39 23 09 39 69 7F FC 60 FA CE 9D E9 A7 7F 3F BD D3 D5 5E B3 92 F4 83 47 AA 2E 5E E8 FE F5 FC 13 AB 20 E8 58 E7 A5 D5 62 86 A1 59 28 43 A1 64 5C 8A 52 C1 A8 07 A5 28 74 B3 BF EF 23 96 0E 5D D8 5F B4 EF F0 F0 3C D4 75 46 83 42 65 10 0E 40 8D 15 B2 36 05 1A 90 D0 20 F4 5C 72 DE 2E FD B4 AE EA C3 DB 3D 43 27 BB 5F 7B D2 69 70 38 1C 26 23 2B A6 2D 52 DA B2 9C 51 5F DF 51 69 51 52 9E E8 B1 A2 F3 08 0A CB F0 F3 8D D6 E4 38 E4 E4 C3 1B 06 E1 EA A3 EF 6E 57 D4 41 78 CE 82 E8 23 BD 36 31 31 54 5B 74 B0 A7 61 A8 A5 65 B8 65 72 B2 A2 A2 67 FF B7 B5 3D 17 5B 2E 3C 1A BA 56 51 31 39 39 39 DC F0 FD AD 89 0F E6 AF B2 9D 57 3B 15 64 3A 60 E5 39 0C B8 7C 9E 35 F2 36 0B 48 F7 4D 07 8D 0D 2D 28 78 B7 BF EF F4 ED D9 1E B3 5E 7C D0 A5 6F 7E 72 60 61 AE 15 95 10 F7 76 B7 D2 3A A0 16 CE 9E B5 3A D4 80 49 AD 16 04 C1 A8 1F B0 AA 2D E4 33 41 30 A9 4D 26 93 C1 3A A0 D7 19 C1 41 14 2A 8E A5 97 C1 70 36 EA 59 54 B2 58 E8 46 AB B2 FD 88 CD D8 15 99 19 8A F2 0F 21 17 59 DB 22 50 03 A5 C2 E0 08 3C CF C2 3F 90 E9 3A 19 AC D5 72 64 82 C1 60 F8 4B D3 E4 23 40 FB 40 0B 9E 8F 75 95 D4 33 51 1A 99 D5 32 80 90 B8 2E 32 1A 01 C1 EB 93 E3 77 6D 78 19 15 CD 8B FD 13 D1 AE B2 5B 2A 6D D0 EA E8 15 2A 5A CB 60 68 3C 7D 80 17 A0 C1 ED 39 15 C7 41 6D F2 1C 78 C6 70 0B C5 AD E2 AB CA 5B 23 C3 77 44 6E DA B6 41 CC BF 2D 02 ED 46 A1 59 78 68 95 1D F5 BC 82 13 0F 41 BB 5C 3E CB B2 0A BD BE 5F A3 B1 D9 2B 41 3A 51 FF 7C 03 AC E5 B9 10 85 02 40 48 66 FE 84 80 DD E2 18 AD 9D 02 DC 56 D8 FA A1 7D C6 0C FC 71 B7 58 BC BD 12 74 BF 18 3A 46 F7 E4 B0 98 07 02 60 80 F4 86 15 BB B4 71 BC C6 EE A5 CD 62 EF A8 D7 1B 55 A4 B4 C7 62 81 F0 E2 28 55 10 47 AB 02 F4 66 5D AA B4 D9 65 00 04 42 6A 25 C0 0C 4D BF 5E AF B1 81 7D 2F 4E 25 47 73 BA FD E0 42 81 20 52 5A 3E 20 F6 96 36 2A 60 68 B4 70 B8 B5 01 32 20 21 A8 DB 40 03 6C 07 15 30 74 50 61 58 2B 02 B4 C0 4C 4C FE 9F 7D 73 7B 6D 1A 0A 03 B8 78 07 15 45 F1 C5 07 51 50 50 C4 87 23 A5 29 44 14 DC 12 9A C2 4E 49 EB 5A 63 43 53 9A 34 D9 DA 90 62 70 B6 6B 1F 6A 09 EC 82 DB 6C 1F E6 8B 8A D6 15 BC 3F 38 5F 36 C1 4B DD 1F A0 3E F8 A0 F8 C7 F8 9D 34 9B F5 86 B7 46 33 E9 CF B1 A5 73 93 F3 F3 BB E4 9C 6F D9 DC A0 DD D0 7D 43 D0 CD 5D E1 5C 0C F6 19 B7 C7 61 2B E1 06 3B 0E CB 63 E1 F6 FD 14 8E FA AE 70 15 FA 43 CC 9F 87 AD 84 1B 6C DC D6 7C 9A 72 DA 50 F8 98 2B 24 C9 D9 7B A1 00 73 15 37 58 B7 55 2B 0E 3A 02 7D A5 63 2E 50 22 FF 74 72 44 70 E9 61 9C 83 BB 6B 43 C1 E5 8D CD 99 63 2E 70 C9 0F 02 97 02 F4 56 37 9E 0A DC BE 65 67 6D C4 19 24 C0 EE C7 0D 81 D3 41 22 00 5B 09 38 13 77 1B 18 9A E2 57 B7 C3 9F B6 09 6E DC 0B C2 67 7D 44 E0 19 19 6C 75 9B BD BB A8 13 F1 B0 FF D3 B6 DE 85 46 7A C1 67 0B A4 16 D1 C1 35 5D E7 10 6A 91 49 D1 4A 00 5C C8 20 38 0F FB EC 08 3C 5C DF FD DB C0 BA 6D EA B5 A4 DF C5 F5 03 E1 F6 FA A3 3E 73 5B F7 33 E8 08 7A 38 D9 11 80 64 D7 FF F7 2F 24 13 4E 72 66 67 D9 7D 6B BA CE 7E D4 48 AD 08 F8 BB 50 00 17 4B A5 0B 25 32 96 38 7D FA 62 09 4E 12 BE E5 63 68 74 F0 96 0B CF 03 EE DD D9 29 70 2A F9 C7 E5 9A 24 E7 E8 BE BE D8 50 22 11 0D F6 9D 22 87 20 87 EC 4D BC 73 4F D7 05 8E 6E 40 F3 1D 11 88 9E FE B3 7C B9 E4 3B E5 EF C4 D7 06 2E A2 93 0B 8A 1B BF A4 B2 05 A1 5A 38 D6 79 1E BE 50 2A 95 C8 74 E7 37 38 97 80 A3 F3 57 F8 61 44 9D 9D 4C 1E CF 93 D1 74 D7 81 71 FA 52 5F D4 B7 82 33 67 88 0D 25 6F 83 CA AF 69 9C 83 6E F9 15 FE E0 9D C9 D4 F4 F1 FB E3 14 2A BB B1 8D 38 80 10 3F 72 C7 FF D5 D0 04 92 17 4E 50 D1 E4 ED 0B 10 8C DF 5D 7F 2C 31 74 3E 1B 1D 9D 1F 17 30 AE 58 F9 77 5D 5F BD F3 5C 4A 6B D2 11 F8 96 06 58 84 CF 90 61 E7 0F DB 65 D4 6F 6F 66 21 7E 30 29 1A 4A 84 E3 D9 C4 B5 77 B3 0F 42 2C 6A 53 75 43 C0 7E 34 4B 9B 4E 5D F3 7D 9F B3 50 97 7D C1 68 E2 D2 99 AB 10 8E 6F 89 40 C3 3C 13 3B 6B 1F 87 B2 D9 78 2A 9E 1A 4C 25 63 63 CF 5F 97 D5 02 46 2B F4 9F 5C D3 7D E0 B9 75 20 B4 30 19 4E 0C 0D D9 03 4F E0 DB 73 38 BB 23 06 63 D1 44 18 C6 59 57 E1 CF 99 33 B7 2F C1 BB 4B E1 24 7C DF 59 BB 76 E2 FE C6 FC CC 83 CB 97 1F 3C 98 5B D2 31 FA 9C 90 1B 02 10 01 82 F1 6A F8 ED D4 C2 35 5F 32 1B 27 A4 E0 2D 95 1A 84 E1 33 F1 82 76 EE 84 02 2C DA 80 0F BC 82 8F 36 ED 0F 70 64 8F 47 26 18 F4 15 AE 46 00 7E E4 D1 06 9B 6A BD 1A 2A 5F 99 79 7F A2 B1 B8 F8 E8 D1 FD D9 D9 A7 C3 D3 6F 17 16 20 9D 07 53 93 90 19 C4 0D 9C CE 87 61 3C DD E7 B3 2D 3A 22 14 1D 9C CC BE 7D 6C 21 F4 B7 05 B6 EF DF 8C BE 84 E1 28 8A C2 98 16 05 53 AD 86 42 E3 B7 1E CF BC 6F DC 7C B5 F8 E2 D1 EC D3 E2 C8 87 85 6B C1 F3 A0 14 0F 27 62 50 B1 90 38 7D C1 3B F1 C4 E8 C3 97 32 FA 0A B7 53 08 D8 B1 E9 E0 63 0D FD 08 90 02 2B B6 62 69 22 AF A8 F9 27 57 5A 27 16 67 87 C7 82 89 3B 10 94 E8 C2 D3 56 DE 42 C0 BF 10 00 D6 5E A7 D0 6F C0 36 79 63 EE C1 9B 99 07 79 01 23 E0 1F 0A 9C B0 05 28 1E 77 94 20 87 29 0E 75 95 7E B7 05 38 BE AE 57 D0 32 0A DF 14 38 D1 62 39 06 FD 04 9E 88 00 24 85 50 30 2D E7 D2 C4 96 91 2F 20 B1 AA 81 9A 48 71 0C C3 31 1E 8F 00 81 AF 39 AD 44 50 90 30 5E 57 39 B1 9F 18 E9 BA 29 4B 26 0F 5F 86 25 41 D4 68 4D A4 3D 29 A0 19 BA C8 D9 2D 87 95 69 24 A8 48 31 84 BA 42 21 BC 14 A2 90 38 A1 4B 08 55 27 20 CD 18 C1 50 18 EF 09 50 B2 C1 B3 4E 2A 89 32 E8 C0 7A 8D 7E CD 2C 08 75 C1 30 F9 7C 4D 54 25 65 5C E6 EB BC 2E 0B 92 07 05 38 8B 45 6D 18 96 82 4B 8E 02 A9 26 43 89 52 13 51 82 40 63 0E 0B 42 85 61 34 49 E4 18 CA 93 45 FC 1D 98 2F 5F 7B B8 88 BF C5 2A 6A A3 5F B2 CA 6E 64 5F C2 7E 33 55 38 66 B5 44 C0 AA 8B 5F 08 F1 A4 C5 0A 34 5A 46 D3 BC 25 C0 70 A8 03 CE 2C 28 14 A6 E0 82 65 C9 EA 31 63 E9 E4 B5 C5 C2 35 7C 25 5C 0B 92 B7 52 88 95 79 16 AD A0 29 F4 52 C1 28 60 10 51 05 24 A8 05 1D D7 97 0C D5 AA D0 86 6A A8 94 55 37 D4 2A EF 2D 01 06 96 06 59 E2 60 8A 42 59 C3 8A 2E 49 18 9B 8A DC C4 82 59 2B B0 52 41 D1 E7 78 6C 4A A6 84 F9 39 C5 5B 29 04 D9 42 9B 55 27 F1 2B 26 C5 AB F0 99 C2 9C CE F3 D5 72 9D E7 A5 90 4A A1 4A C1 94 75 0E 55 AA 3A D9 21 C9 DE 8A 00 40 09 13 4E 5E 4B 12 E2 C9 22 D5 B2 21 49 CA 44 5D 52 24 53 A6 50 53 37 15 09 0A C1 16 90 15 8F 09 B0 82 2A 57 EC 48 B0 D8 AC 20 B9 8C 11 5F 30 78 C4 49 50 CF 88 D6 75 16 35 0B BA 2C C3 B5 61 68 48 2B 9B DE 12 A0 64 B3 C9 38 26 22 04 C2 CA AB 92 4A E3 BA 6C E8 B8 60 C8 75 5E A0 C8 6E 5A 80 3A B1 78 51 85 A3 B1 E6 2D 01 86 5D AE 60 86 E2 88 09 53 11 59 B0 11 69 06 51 1A 5C DA 9F 03 C8 7B 84 45 CC 78 FC 4E 8C 7A 7B A1 FF 2C 02 3D 81 9E 40 AF 88 D7 B4 59 AD 02 BD 08 F4 04 7A 29 B4 A6 4D 4F A0 27 D0 AB 01 2F 08 D0 75 7E 55 0B 54 1F 05 9E BD C4 AB 57 40 39 7E 23 9D C9 BD A6 51 07 2C B7 7A 04 B8 99 A9 62 24 72 EF 46 AB 63 CD 7A E3 D6 EA 11 50 46 EF 06 06 06 02 E9 E1 25 B4 8C F5 E2 D8 09 C6 CB 5D 08 DF BA 7E 45 41 0E B7 D2 C3 01 60 20 37 BF 12 82 FE 1B A3 75 2F 47 80 9D 9F CA E5 46 1F 3B 65 FB 26 07 01 00 83 CC 0B BC FC F7 F9 27 92 A7 8B B8 3F 7D 37 50 4C 67 5E 8B 08 D0 1E 65 22 03 01 20 FD A8 E2 AC BF 6C 78 FB 46 C6 5E BF 11 09 04 22 F7 A6 5E 91 EE 6F CC A6 23 10 82 81 4F 02 B5 32 E5 ED 36 CA DF CF 90 9C 0F 0C 4F 35 9A 08 E5 23 23 01 9B CC 4D 16 11 F4 CB 5A 3B 8F AE 5F C1 DE 14 90 8E 67 60 F9 03 60 30 D6 A2 50 28 D0 16 28 66 5A 0C 02 98 87 13 88 4C AC D5 D1 93 37 69 6F A6 50 3B 02 C4 E0 5E 7A 82 44 20 62 5F 4F F7 23 82 72 59 64 6B 97 5B F9 4A 28 AF 31 DE 8C 00 FB 66 8A 2C 9F BC 8D BD 60 0B A3 20 00 64 9E 8B 88 30 91 E7 5B D7 F3 D8 D3 77 E2 5A 66 38 02 65 4B CA 20 5D A3 9F A7 23 E0 53 1C 7B 8C 6C 96 CA F3 2F 2B DE 2E 62 84 DF 93 10 D8 CD 3F D7 A8 34 72 A4 8D E6 8E 0B C8 A6 FC AA EA FD F3 80 7C 1C 0C 6C 81 91 A2 FA 30 07 3D 75 3A 3D 87 00 AA FA F2 F9 1B CB FB 02 68 69 14 36 70 01 3B 04 57 CA D3 C3 91 E2 D4 3C F9 B6 66 EB 5E 6E 64 E0 45 3F EB F1 14 02 D4 FB 63 ED EE 99 59 1C 9F 9D 2E 4E 35 68 52 DD 33 37 EE 42 5D E4 D2 33 3A E5 75 81 8F EC 9C CF 6B E2 40 14 C7 77 FF A4 9C 1C A8 78 DA 04 22 44 70 F6 24 2B 2C 8C 8E 32 8C 28 08 C1 64 7B 90 65 61 CC C1 FC E8 A1 5E 96 90 9A ED 25 29 3D D4 9E 14 5A 6D F7 0F 68 3D DA BF 66 F3 62 61 F7 B2 47 97 CC D6 2F 9A 43 48 20 9F CC 77 DE 7B CC 4B A2 D4 1F 98 20 0C 61 0B FF 58 4E A7 F3 66 EE 0B 92 07 24 D7 5E 4D 82 71 B1 2D 04 FA BA B5 89 A0 24 F2 43 B1 B8 DC 87 57 8E 32 A5 69 30 8C 4F 07 85 2E A7 F7 D2 7B AB ED CD B9 FB 54 0D B4 D7 04 97 20 03 61 52 EE 2C 77 0F 93 7A C1 2D B4 97 DA FD DC 1F E9 8A AE C1 49 8D B2 69 64 00 E6 9D 33 FF 7E 7E DA 91 02 20 BB 6A 70 BF 73 11 C6 6D B5 BE 4E F6 45 91 3F 60 CB 60 20 03 C0 65 F5 39 5D 64 66 8F 23 CE CF 5B DA 05 31 C0 43 AE 15 77 5A 0B 5F 2D FC 1C 50 6A A1 10 BB 8A 96 5D 8E E1 BA C2 51 AE B9 81 80 C0 B4 3C 8F D8 AD E2 03 7C DB 44 88 2E 9B B0 B0 42 B0 F0 95 0E 33 51 AE 94 F3 54 DC 4A 60 21 9F A3 04 BE 5C A9 57 28 26 E5 A6 E2 45 56 5E 68 C3 4F 2C 4F 0A 3D 02 5D A8 DD 56 84 59 A6 03 2B 13 09 B3 E8 B5 D2 B8 8A 0C 0C 35 52 F6 27 76 BB C8 23 A0 85 E0 90 81 61 62 EA 95 20 82 52 EC 9A 81 D2 BA 8A 5C 84 11 C8 64 A3 22 03 7C D8 F9 D9 B6 79 45 B1 69 C3 12 CA 4C 58 98 B0 58 6D 84 A6 20 CC 42 C8 88 EC 46 81 01 6A F3 4F 10 7D 14 8F 22 8B CF D4 0C 65 CD 31 16 AC A7 94 AA 73 44 39 E7 53 BA D2 0B 0C D0 C3 D1 3D DC 78 C7 65 98 D8 C3 DC 4D 14 F3 9B 2E C0 F5 1F BD CA 8B 57 D5 8B 1C 46 27 26 31 3F 40 26 5B 13 84 78 3E 18 13 16 89 F8 F7 6B 4E 6A B1 AB D1 38 49 E9 16 0E BC E5 0C 33 FA 98 BB C2 D8 5C 4A D3 1F A8 A6 A9 8B FB AF 6B 44 38 61 01 EC 1C B6 E5 69 70 D4 CB 1C F3 10 6C 12 73 17 21 8A 1C 99 9A 7C A3 7E 96 C2 A6 29 63 03 98 B2 CF 53 86 31 A1 33 4D 16 00 6D 45 9F 74 A5 E6 4D 09 BF 69 42 4A BE 88 DC 84 12 5F 93 A4 47 76 B6 D9 91 C5 38 E3 B8 BD A3 1F 2B 63 C8 66 2F F4 CE EB 94 E4 B0 50 77 66 97 67 ED 7D 07 6F 78 BD C1 2B 15 62 69 D0 D3 E5 68 74 EB 1D 3F 74 6A 7F B8 A9 75 A6 49 D5 A9 6F 0E 46 25 A9 3B F5 9A FE BF 3E 6A F0 06 01 AA 47 80 23 C0 71 0E EC 75 04 38 02 BC 51 00 E9 27 F1 11 E0 EF 00 5B E5 5F E8 E7 E1 00 5E 4E C6 27 07 57 6D 72 30 80 F7 D1 FD BA 7C 70 AD AD 2F EF 0E A4 5F EC C1 31 01 00 00 08 03 20 4D 34 FB A7 B3 C5 2E E0 B2 15 19 00 00 00 00 00 00 00 9E 3D 38 10 00 00 00 00 00 F2 7F 6D 04 55 55 55 55 55 55 55 55 55 55 55 55 55 55 95 8D 82 51 30 B4 00 00 31 3D 74 A7 07 21 F9 96 00 00 00 00 49 45 4E 44 AE 42 60 82").Replace(" ", ""))
                Delete(False, tempdir + "\restore-images\images-2x\applelogo.png")
                Using writer As BinaryWriter = New BinaryWriter(File.Open(tempdir + "\restore-images\images-2x\applelogo.png", FileMode.Create))
                    writer.Write(ChristmasLogoInBytes)
                    writer.Close()
                End Using
            End If


        End If
    End Sub

End Class
