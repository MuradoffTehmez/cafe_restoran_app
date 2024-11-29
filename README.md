# CafeRestoranApp

**CafeRestoranApp** kafe və restoran idarəetməsi üçün hazırlanmış bir Windows Forms tətbiqidir. Layihə, kafe və restoran müdirlərinə və işçilərinə gündəlik işlərini effektiv şəkildə idarə etməyə kömək etmək məqsədi güdür. Tətbiq, müştəri sifarişlərinin qeydiyyatını, menyu idarəetməsini və digər restoran əməliyyatlarını sadələşdirir. **DevExpress** komponentləri ilə istifadəçi interfeysi, **Entity Framework** vasitəsilə verilənlər bazası ilə sıx inteqrasiya edilmişdir.

## Xüsusiyyətlər
- **Menyu İdarəetməsi:**
  - Yenisini əlavə etmək: Menyuya yeni məhsullar əlavə edə bilərsiniz.
  - Silmək: Menyudakı artıq məhsulları silmək mümkündür.
  - Yeniləmək: Mövcud məhsulun məlumatlarını yeniləmək (ad, qiymət, təsvir və s.).
  
- **Sifariş İdarəetməsi:**
  - Müştəri sifarişləri qeyd edilir və izlənilir.
  - Sifarişlərin ödənişi və sifarişin tamamlanması prosesləri.
  
- **DevExpress UI Komponentləri:**
  - **GridControl**: Menyu və digər məlumatları effektiv şəkildə göstərmək üçün istifadə olunur.
  - **DateEdit, TimeEdit**: Tarix və saat məlumatlarını düzgün şəkildə göstərmək üçün istifadə olunur.
  - **SimpleButton**: Sadə düymələr vasitəsilə əməliyyatlar (əlavə et, sil, yenilə və s.) həyata keçirilir.
  
- **Verilənlər Bazası İdarəetməsi (Entity Framework):**
  - **Verilənlər Bazası İnterfeysi**: Restoranın menyusunun, sifarişlərin və digər məlumatların idarə edilməsi üçün SQL Server verilənlər bazası istifadə olunur.
  - **CRUD Əməliyyatları**: Yaradılma, oxunma, yeniləmə və silinmə əməliyyatları `Entity Framework` vasitəsilə həyata keçirilir.
  - **Lazy Loading**: Verilənlər bazası ilə əlaqə qurulmazdan əvvəl lazımi məlumatları yükləmək üçün istifadə olunur.
  
- **İstifadəçi Təcrübəsi (UI/UX):**
  - Tətbiq **DevExpress** UI komponentləri ilə hazırlanmış və istifadəçi dostu interfeysi təmin edən bir çox vizual elementi ehtiva edir.
  - **Responsive Design**: Proqramın müxtəlif ekran ölçülərində düzgün işləməsi təmin edilir.

## Texnologiyalar
- **C# və .NET Framework**:
  - Tətbiq əsasən **C#** dilində yazılmışdır və **.NET Framework** istifadə olunur.
  - **Windows Forms** platformasında inkişaf etdirilmişdir, bu da tətbiqin masaüstü mühitində istifadə edilməsi üçün ideal edir.

- **DevExpress UI Komponentləri**:
  - **DevExpress** istifadə edilərək inkişaf etdirilmişdir. Bu, proqramın vizual cəhətdən zəngin və istifadəçi dostu olmasını təmin edir.
  - **DevExpress GridControl**: Verilənlər bazasından əldə olunan məlumatların cədvəl formasında göstərilməsi.
  - **DevExpress Buttons**: Proqramın interfeysində sadə və effektiv düymələr.

- **Entity Framework**:
  - **Entity Framework** verilənlər bazası ilə əlaqə qurulmasına kömək edir.
  - **Code First** yanaşması ilə verilənlər bazası strukturu kod vasitəsilə yaradılır.
  - **LINQ** istifadə edilərək verilənlər bazasına sorğular göndərilir.

## Qrafiklər və Görsellik
- **DevExpress Charts** və **Reports** istifadə edilərək satış və sifarişlərlə bağlı hesabatlar və qrafiklər yaradılacaq.

## Gələcək Planlar
- **Müştəri Əlaqə İdarəetməsi (CRM)**: Müştəri məlumatlarını toplayaraq daha yaxşı xidmət təqdim etmək üçün bir CRM sistemi inteqrasiya ediləcək.
- **Statistika və Hesabatlar**: Restoranın satış və sifariş statistikasını təhlil edəcək və hesabatlar yaradacaq bir modul əlavə ediləcək.
- **Online Menyu və Sifariş Sistemi**: Müştərilərin öz cihazlarından menyuya baxıb sifariş verməsi üçün bir veb tətbiqi əlavə ediləcək.
- **Mobil Tətbiq**: Restoran sahibinin və işçilərinin məlumatlara mobil cihazlardan asanlıqla daxil olmaları üçün mobil tətbiq hazırlanacaq.

## İstifadəçi Quraşdırması
1. **Proqramı yükləyin**:
   - Proqramı GitHub-dan və ya digər bir yerdən yükləyin.
   
2. **Əlavə Tələblər**:
   - **Microsoft SQL Server**: Verilənlər bazası üçün tələb olunur.
   - **DevExpress**: UI komponentləri üçün tələb olunur.

3. **İnkişaf Mühiti**:
   - **Visual Studio** və ya **JetBrains Rider** kimi IDE-lərdən istifadə edə bilərsiniz.

4. **Verilənlər bazası konfiqurasiyası**:
   - `CafeContext` verilənlər bazasının konfiqurasiyasını idarə edir. Verilənlər bazasını yaratmaq üçün `Entity Framework` ilə migrasiya əməliyyatlarını həyata keçirin.

5. **Proqramı işə salın**:
   - Tətbiqi başlatmaq üçün `frm_Menu` formunu açın və proqramın işini izləyin.

---

### **Layihənin Üstünlükləri**
- **Effektiv İdarəetmə**: Restoranın gündəlik əməliyyatlarını sadələşdirir və avtomatlaşdırır.
- **İstifadəçi Dostu İnterfeys**: İstifadəçilər üçün sadə və intuitiv interfeys.
- **Çoxsaylı İntegrasiyalar**: DevExpress, Entity Framework və Windows Forms istifadə edərək inkişaf etdirilmişdir.

---

Bu README faylı layihənin əsas məqsədini və necə istifadə olunacağını izah edir. Layihə restoran və kafe idarəçiliyi üçün tam funksional bir həll təqdim edir.
